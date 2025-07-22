using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace CONTROLADORA.ServiciosCorreo
{
    public abstract class ServicioCorreoMaster
    {
        private SmtpClient Smtpcliente;
        protected string remitente { get; set; }
        protected string contraseña { get; set; }
        protected string servidor { get; set; }
        protected int puerto { get; set; }
        protected bool ssl { get; set; }

        protected void InicializarCliente()
        {
            Smtpcliente = new SmtpClient();
            Smtpcliente.Credentials = new NetworkCredential(remitente, contraseña);
            Smtpcliente.Host = servidor;
            Smtpcliente.Port = puerto;
            Smtpcliente.EnableSsl = ssl;
        }

        public void EnviarCorreo(string asunto, string msj, List<string> destinatarios)
        {
            var MailMessage = new MailMessage();
            try
            {
                MailMessage.From = new MailAddress(remitente);
                foreach (string destino in destinatarios)
                {
                    MailMessage.To.Add(destino);
                }
                MailMessage.Subject = asunto;
                MailMessage.Body = msj;
                MailMessage.Priority = MailPriority.Normal;

                Smtpcliente.Send(MailMessage);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al enviar el correo: " + ex.Message);
            }
            finally
            {
                MailMessage.Dispose();
                Smtpcliente.Dispose();
            }
        }

    }
}
