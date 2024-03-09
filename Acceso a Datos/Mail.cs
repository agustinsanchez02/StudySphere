using MODELO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_Datos
{
    public class Mail
    {
        MODELO.Entidades.Usuario usuario = new MODELO.Entidades.Usuario();
        public MailMessage MailVerificar(string usuario_mail, int codigoazar)
        {

            MailMessage correo = new MailMessage();
            correo.To.Add(usuario_mail);
            correo.Subject = "Solicitud de cambio de contraseña";
            correo.SubjectEncoding = Encoding.UTF8;
            correo.Body = "<h2 style='color:#6bf286'>StudySphere\n</h2>" + "<h1>Sistema de solicitud de cambion de contraseña</h1>\n" + "Estimado " + usuario.User + ": " + "\n\n\n <p><b>Su código de verificación es: </b></p>" + codigoazar.ToString() + "<p>\nSí no reconoce está actividad, por favor ignorela.\nGracias.</p>";
            correo.BodyEncoding = Encoding.UTF8;
            correo.IsBodyHtml = true;
            correo.From = new MailAddress("StudySphere@hotmail.com");

            return correo;
        }
        
        public MailMessage Mail_Registro(string usuario_mail, string usuario_nombre, string usuario_apellido, string usuario)
        {
            MailMessage correo = new MailMessage();

            correo.To.Add(usuario_mail);
            correo.Subject = "Registro completo con exito";
            correo.SubjectEncoding = Encoding.UTF8;
            correo.Body = "<h2 style='color:#6bf286'>StudySphere\n</h2>" + "<h1>¡Su registro fue exitoso!</h1>" + "<p><b>Muchas gracias por confiar en nosotros  </b></p>" + usuario_nombre + " " + usuario_apellido + ", su nombre de usuario es: " + usuario;
            correo.BodyEncoding = Encoding.UTF8;
            correo.IsBodyHtml = true;
            correo.From = new MailAddress("StudySphere@hotmail.com");

            return correo;
        }

        public MailMessage Mail_cambiopass(string mail)
        {
            MailMessage correo = new MailMessage();

            correo.To.Add(mail);
            correo.Subject = "Su contraseña se ha modificado correctamente";
            correo.SubjectEncoding = Encoding.UTF8;
            correo.Body = "<h2 style='color:#6bf286'>StudySphere\n</h2>" + " Estimado " + usuario.User + ": \n" + "<h1>¡Su cambio de contraseña fue exitoso!</h1>" + "<p><b>Muchas gracias por confiar en nosotros.  </b></p> Si usted no reconoce esta accion por favor comuniquese con soporte.";
            correo.BodyEncoding = Encoding.UTF8;
            correo.IsBodyHtml = true;
            correo.From = new MailAddress("StudySphere@hotmail.com");

            return correo;
        }
        public SmtpClient SmtpClient()
        {
            SmtpClient smtpClient = new SmtpClient();

            smtpClient.Credentials = new System.Net.NetworkCredential("StudySphere@hotmail.com", "Agustin1504");
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Host = "smtp.office365.com";

            return smtpClient;
        }
    }
}
