using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes.Auxiliar
{
    class Email
    {
        public void Enviar(string para, string mensagem)
        {


        https://myaccount.google.com/lesssecureapps?pli=1
            string remetente = "thiago.oliveira.santana.16@gmail.com";
            string senha = "22113366";


            string assunto = "Nova Mensagem | Estágio";
            mensagem = CriarMensagemComHtml(mensagem);

            // Configura a mensagem
            MailMessage email = new MailMessage();

            // Configura Remetente, Destinatário
            email.From = new MailAddress(remetente);
            email.To.Add(para);

            // Configura Assunto, Corpo e se o Corpo está em Html
            email.Subject = assunto;
            email.Body = mensagem;
            email.IsBodyHtml = true;



            // Configura os parâmetros do objeto SMTP
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;


            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(remetente, senha);

            // Envia a mensagem
            smtp.Send(email);


        }

        public string CriarMensagemComHtml(string mensagem)
        {
            // Lê o html do arquivo email.html
            string html = File.ReadAllText("Classes/Auxiliares/PluginEmail/EmailHTML.html");

            // Substitui as quebras de linhas pela tag <br>
            mensagem = mensagem.Replace("\n", "<br>");

            // Coloca a mensagem no template em html
            mensagem = html.Replace("{MENSAGEM}", mensagem);

            return mensagem;
        }
    }
}
