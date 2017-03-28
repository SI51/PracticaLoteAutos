using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoteAutos.Modelo;
using System.Linq;
using System.Windows.Forms;

namespace LoteAutos.Controladores
{
    public class clsManejoSesion
    {
        public static SessionHelper Login(String User, String Password)
        {
            SessionHelper objSession = new SessionHelper();
            try
            {
                using (var ctx = new DataModel())
                {
                    Usuario user = ctx.usuarios.Where(r => r.sUsuario == User && r.bStatus == true).FirstOrDefault();
                    if (user != null)
                    {
                        if (user.sContrasena == Password)
                        {
                            objSession.isValid = true;
                            objSession.usuario = user;
                        }
                    }
                }
                return objSession;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public class SessionHelper
        {
            public Boolean isValid { get; set; }
            public Usuario usuario { get; set; }
            public String msgError { get; set; }

            public SessionHelper()
            {
                this.isValid = false;
                this.usuario = null;
                this.msgError = "Datos incorrectos";
            }
        }
    }
}
