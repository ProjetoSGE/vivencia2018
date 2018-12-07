
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Catiotro_s.PlugIn
{
    public class EmailPlugin
    {
        public string Para { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }


        MailMessage email = new MailMessage();

        public void Enviar()
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    //-----> https://myaccount.google.com/lesssecureapps?pli=1
                    string remetente = "nerdt21@gmail.com";
                    string senha = "1234567891123a";

                    email.From = new MailAddress(remetente);
                    email.To.Add(this.Para);

                    email.Subject = this.Assunto;
                    email.Body = this.Mensagem;
                    email.IsBodyHtml = true;

                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;

                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(remetente, senha);

                    smtp.Send(email);

                });
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro.");
            }

        }


        public void AdicionarAnexo(string arquivo)
        {
            try
            {
                Attachment inline = new Attachment(arquivo);
                this.email.Attachments.Add(inline);
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro.");
            }

        }


    }
}

