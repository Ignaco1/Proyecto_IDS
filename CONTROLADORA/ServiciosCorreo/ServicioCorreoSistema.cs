using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA.ServiciosCorreo
{
    public class ServicioCorreoSistema:ServicioCorreoMaster
    {
        public ServicioCorreoSistema()
        {
            remitente = "servicios.vitastays@gmail.com";
            contraseña = "qiha dqck casp epqn";
            servidor = "Smtp.gmail.com";
            puerto = 587;
            ssl = true;

            InicializarCliente();
        }
    }
}
