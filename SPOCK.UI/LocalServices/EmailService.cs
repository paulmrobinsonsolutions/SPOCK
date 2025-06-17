using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace SPOCK
{
    public class EmailService
    {
        public string SendEmail(string inToAddress, string inSubject, string inBody)
        {
            string errResult = string.Empty;

            try
            {
                // Create the Outlook application by using inline initialization.
                Outlook.Application oApp = new Outlook.Application();

                //Create the new message by using the simplest approach.
                Outlook.MailItem oMsg = (Outlook.MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);

                //Add a recipient.
                Outlook.Recipient oRecip = (Outlook.Recipient)oMsg.Recipients.Add(inToAddress);
                oRecip.Resolve();

                //Set the basic properties.
                oMsg.Subject = inSubject;
                oMsg.HTMLBody = inBody;
                oMsg.Importance = Outlook.OlImportance.olImportanceHigh;

                ////Add an attachment.
                //// TODO: change file path where appropriate
                //String sSource = "C:\\setupxlg.txt";
                //String sDisplayName = "MyFirstAttachment";
                //int iPosition = (int)oMsg.Body.Length + 1;
                //int iAttachType = (int)Outlook.OlAttachmentType.olByValue;
                //Outlook.Attachment oAttach = oMsg.Attachments.Add(sSource, iAttachType, iPosition, sDisplayName);

                // If you want to, display the message.
                // oMsg.Display(true);  //modal

                //Send the message.
                oMsg.Save();
                oMsg.Send();

                //Explicitly release objects.
                oRecip = null;
                //oAttach = null;
                oMsg = null;
                oApp = null;
            }

            // Simple error handler.
            catch (Exception e)
            {
                errResult = e.Message;
            }

            return errResult;
        }
    }
}
