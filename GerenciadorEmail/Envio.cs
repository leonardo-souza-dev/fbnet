using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace GerenciadorEmail
{
    public class Envio
    {
        public async Task<bool> EnviaEmailContato(string fromName, string fromEmail, string messageField, string toEmail = "blog.naovah@gmail.com")
        {
            var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
            var message = new MailMessage();
            message.To.Add(new MailAddress(toEmail));
            message.From = new MailAddress("leonardotreze@gmail.com");
            message.Subject = "Your email subject";
            message.Body = string.Format(body, fromName, fromEmail, messageField);
            message.IsBodyHtml = true;
            using (var smtpClient = new SmtpClient("smtp.gmail.com", 587))
            {
                var credential = new NetworkCredential();
                credential.UserName = "leonardotreze@gmail.com";
                credential.Password = "";
                smtpClient.Credentials = credential;
                smtpClient.EnableSsl = true;
                await smtpClient.SendMailAsync(message);

                return true;
            }
        }
    }
}
