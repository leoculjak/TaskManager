﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using MyCompany.Data;

namespace MyCompany.Models
{
    public enum UsersDataField
    {

        ID,

        UserName,

        Password,

        Email,

        OrganizationID,

        OrganizationName,

        Roles,

        PasswordConfirmation,
    }

    public partial class UsersModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iD;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _userName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _password;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _email;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _organizationID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _organizationName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _roles;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _passwordConfirmation;

        public UsersModel()
        {
        }

        public UsersModel(BusinessRules r) :
                base(r)
        {
        }

        public int? ID
        {
            get
            {
                return _iD;
            }
            set
            {
                _iD = value;
                UpdateFieldValue("ID", value);
            }
        }

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                UpdateFieldValue("UserName", value);
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                UpdateFieldValue("Password", value);
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                UpdateFieldValue("Email", value);
            }
        }

        public int? OrganizationID
        {
            get
            {
                return _organizationID;
            }
            set
            {
                _organizationID = value;
                UpdateFieldValue("OrganizationID", value);
            }
        }

        public string OrganizationName
        {
            get
            {
                return _organizationName;
            }
            set
            {
                _organizationName = value;
                UpdateFieldValue("OrganizationName", value);
            }
        }

        public string Roles
        {
            get
            {
                return _roles;
            }
            set
            {
                _roles = value;
                UpdateFieldValue("Roles", value);
            }
        }

        public string PasswordConfirmation
        {
            get
            {
                return _passwordConfirmation;
            }
            set
            {
                _passwordConfirmation = value;
                UpdateFieldValue("PasswordConfirmation", value);
            }
        }

        public FieldValue this[UsersDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}