using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace fundimetal_core
{
    public class MailManager
    {

        private String RutaConfigMail  = System.AppDomain.CurrentDomain.BaseDirectory + "Referencia\\ConfigCorreo.xml";
        private String ServerSmtp { get; set; }
        private String User { get; set; }
        private String Password { get; set; }
        private int Port { get; set; }


        private String From { get; set; }
        private String To { get; set; }
        private List<String> lst_To { get; set; }

        private String Subject { get; set; }
        private String Body { get; set; }
        public List<String> ArchivosAdjunto = new List<string>();
 
        private  XmlDocument XdocConfigMail;


        private MailMessage mail;
        private SmtpClient SmtpServer;


        public MailManager()
        {
            LoadConfig();
        }


        /// <summary>
        /// Carga la configuracion para el envio de correos
        /// </summary>
        private void LoadConfig()
        {
            #region Parametros del correo 
            XdocConfigMail = new XmlDocument();
            XdocConfigMail.Load(RutaConfigMail);

            ServerSmtp = XdocConfigMail.SelectSingleNode("/Configuracion/ServerSMTP").InnerText;
            User = XdocConfigMail.SelectSingleNode("/Configuracion/User").InnerText;
            Password = XdocConfigMail.SelectSingleNode("/Configuracion/Password").InnerText;
            Port = Convert.ToInt16(XdocConfigMail.SelectSingleNode("/Configuracion/Port").InnerText);


            From = XdocConfigMail.SelectSingleNode("/Configuracion/From").InnerText;
            To = XdocConfigMail.SelectSingleNode("/Configuracion/To").InnerText;
            Subject = XdocConfigMail.SelectSingleNode("/Configuracion/Subject").InnerText;
            Body = XdocConfigMail.SelectSingleNode("/Configuracion/Body").InnerText;

            #endregion


            #region Servidor del correo

            mail = new MailMessage();

            SmtpServer = new SmtpClient(ServerSmtp);
            mail.From = new MailAddress(From);


            var listTo = To.Split(',');
            foreach (var toAdresss in listTo)
            {
                mail.To.Add(toAdresss);
            }

            mail.Subject = Subject;
            mail.Body = Body;

            SmtpServer.Port = Port;
            SmtpServer.Credentials = new System.Net.NetworkCredential(User, Password );
            SmtpServer.EnableSsl = true;

            #endregion
        }



        public void  SendMail() {

            if (ArchivosAdjunto != null )
            {
                if (ArchivosAdjunto.Count > 0 )
                {
                    foreach (var archivoAdjunto in ArchivosAdjunto)
                    {                        
                        System.Net.Mail.Attachment attachment;
                        attachment = new System.Net.Mail.Attachment(archivoAdjunto);
                        mail.Attachments.Add(attachment);
                    }
                }
            }
            var nameFile = Path.GetFileName(ArchivosAdjunto[0].ToString());
            mail.Subject = mail.Subject + " <" + nameFile  + ">";
            SmtpServer.Send(mail);
        }

        


    }


}
