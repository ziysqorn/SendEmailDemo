using System.Net;
using System.Net.Mail;

namespace EmailAuth.Service
{
    public class MailUtils
    {
        public static async Task SendEmail(string _from, string _to, string _subject, string _body)
        {
            MailMessage message = new MailMessage(_from, _to, _subject, _body);
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;
            message.Sender = new MailAddress(_from);

            using var smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("tranduyquan2003@gmail.com", "eiuy lmcq vpxs vucf");
            try
            {
                await smtpClient.SendMailAsync(message);
            }
            catch (Exception ex)
            {
				Console.WriteLine(ex.ToString());   
			}

        }
    }
}
