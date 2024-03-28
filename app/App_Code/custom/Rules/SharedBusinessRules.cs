using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using MyCompany.Data;
using System.Xml.XPath;
using System.Xml;

namespace MyCompany.Rules
{
    public partial class SharedBusinessRules : MyCompany.Data.BusinessRules
    {
        public int OrganizationId
        {
            get
            {
                object result = SqlText.ExecuteScalar("SELECT OrganizationId from Users WHERE Id = @p0", UserId);
                return result is DBNull ? -1 : (int)result;
            }
        }

        protected override void EnumerateDynamicAccessControlRules(string controllerName)
        {
            base.EnumerateDynamicAccessControlRules(controllerName);
            if (!UserIsInRole("Administrators"))
            {
                RegisterAccessControlRule("OrganizationID", AccessPermission.Allow, OrganizationId);
                RegisterAccessControlRule("RoleId", AccessPermission.Deny, 1);
                if (!UserIsInRole("Owners"))
                {
                    RegisterAccessControlRule("CreatedBy", AccessPermission.Allow, UserId);
                }
            }
        }

        protected override void VirtualizeController(string controllerName)
        {
            base.VirtualizeController(controllerName);
            if (controllerName == "Users" && UserIsInRole("Administrators"))
            {
                NodeSet().SelectActionGroup("ag1").CreateAction("Custom", "Impersonate")
                    .SetHeaderText("Impersonate").Attr("cssClass", "material-icon-group-add");
            }
        }

        [ControllerAction("Users", "Custom", "Impersonate")]
        public void HandleImpersonate()
        {
            var userToImpersonate = (string)SelectFieldValue("UserName");
            if (!string.IsNullOrEmpty(userToImpersonate)
                && !userToImpersonate.Equals("admin", StringComparison.InvariantCulture)
                && UserIsInRole("Administrators"))
            {
                var password = StringEncryptor.ToBase64String(DateTime.Now);
                Result.ExecuteOnClient(@"
$app.login('" + userToImpersonate + @"', 'impersonate:" + password + @"', false, function () {
    setTimeout(function () {
        $app._navigated = true;
        window.location.replace($app.touch.returnUrl() || __baseUrl);
    });
});");
            }
        }

        public override bool SupportsVirtualization(string controllerName)
        {
            return true;
        }

        public override void VirtualizeController(string controllerName, XPathNavigator navigator, XmlNamespaceManager resolver)
        {
            base.VirtualizeController(controllerName, navigator, resolver);
            if (!UserIsInRole("Administrators"))
            {
                if (controllerName == "Users" && controllerName == "Receipts")
                {
                    NodeSet().SelectViews("grid1", "createForm1", "editForm1").SelectDataField("OrganizationID").Hide();
                }
            }
        }
    }
}
