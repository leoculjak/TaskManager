namespace FreeTrial.Handlers
{


    public partial class BlobFactoryConfig : BlobFactory
    {

        public static void Initialize()
        {
            // register blob handlers
            RegisterHandler("AttachmentBlobHandler", "\"dbo\".\"Attachments\"", "\"Attachment\"", new string[] {
                        "\"Id\""}, "Attachments Attachment", "Attachments", "Attachment");
        }
    }
}
