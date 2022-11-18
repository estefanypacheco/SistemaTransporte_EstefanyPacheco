using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class GestionEmail
    {
        public string CorreoDestino;
        public string Asunto;
        public string Mensaje;

        public bool EnviarCorreo_Net_Mail_SmtpClient()
        {
            try
            {
                if (Mensaje != String.Empty && CorreoDestino != String.Empty)
                {

                    System.Net.Mail.MailMessage correo = new System.Net.Mail.MailMessage();
                    correo.From = new System.Net.Mail.MailAddress("transportespalmares21@gmail.com");
                    //remitente
                    correo.Subject = Asunto;

                    correo.To.Add(CorreoDestino);

                    correo.Body = Mensaje;

                    correo.IsBodyHtml = false;
                    System.Net.Mail.SmtpClient Servidor = new System.Net.Mail.SmtpClient();

                    Servidor.Host = "smtp.gmail.com";
                    Servidor.Port = 587;

                    Servidor.EnableSsl = true;
                    Servidor.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;

                    Servidor.Credentials = new System.Net.NetworkCredential("transportespalmares21@gmail.com", "Ep2022pract*");

                    Servidor.Send(correo);

                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}

