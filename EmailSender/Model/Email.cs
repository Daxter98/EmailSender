using System.Net;
using System.Net.Mail;

namespace EmailSender.Model
{
    /*
     * El modelo es la logica del negocio.
     */
    internal class Email
    {
        // Configuracion para la cuenta de correo
        private readonly string USUARIO = "c41mse@gmail.com";
        private readonly string PASSWORD = "kynjuevtyhleuwqc";

        public string? EmailAddress { get; set; }
        public string? EmailSubject { get; set; }
        public string? EmailBody { get; set; }

        public void SendEmail()
        {
            try
            {
                MailMessage message = new();
                // Cliente SMTP 
                SmtpClient smtpClient = new("smtp.gmail.com");

                message.From = new MailAddress("c41mse@gmail.com");
                message.To.Add(EmailAddress);
                message.Subject = EmailSubject;
                message.Body = EmailBody;

                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(USUARIO, PASSWORD);
                smtpClient.EnableSsl = true;

                smtpClient.Send(message);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
