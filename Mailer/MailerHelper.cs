using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Diagnostics;

namespace Mailer
{
    static class MailerHelper
    {

        static public event Action<DateTime, string> Action;
        static public bool Sent(MailMessage message, string password)
        {
            try
            {
                string subject = message.Subject;// tbSubject.Text;
                //string password = password; //System.IO.File.ReadAllText("C:\\temp\\1.txt");
                int port = 587;
                string body = message.Body;
                var smtp = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = port,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("geekbrains2021@gmail.com", password)
                };
                Action?.Invoke(DateTime.Now, "Message is sending");
                smtp.Send(message);
                //MessageBox.Show("Message has sent");
                //Debug.WriteLine("Message has sent");
                Action?.Invoke(DateTime.Now, "Message has sent");
                System.Diagnostics.Debug.WriteLine("From:" + message.From);
                System.Diagnostics.Debug.WriteLine("To:" + message.To);
                System.Diagnostics.Debug.WriteLine("Body:" + message.Body);
                return true;
            }
            catch (Exception ex)
            {
                //using System.Diagnostic
                Debug.WriteLine(ex);
                //Console.WriteLine(ex);
                Action?.Invoke(DateTime.Now, ex.Message);
                return false;
            }
        }
    }
}
