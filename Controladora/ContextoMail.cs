using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Acceso_a_Datos;

namespace Controladora
{
    public class ContextoMail
    {
        Mail mail = new Mail();
        public MailMessage MailVerificar(string usuario_mail,int codigoazar)
        {
            return mail.MailVerificar(usuario_mail, codigoazar);
        }

        public MailMessage Mail_Registro(string usuario_mail, string usuario_nombre, string usuario_apellido, string usuario)
        {
            return mail.Mail_Registro(usuario_mail, usuario_nombre, usuario_apellido, usuario);
        }

        public MailMessage Mail_cambiopass(string usuario_mail)
        {
            return mail.Mail_cambiopass(usuario_mail);
        }
        public SmtpClient SmtpClient()
        {
            return mail.SmtpClient();
        }
    }
}
