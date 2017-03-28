using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using LoteAutos.Controladores;

namespace LoteAutos
{
    public partial class frmLogin : Form
    {
        //clsManejoSesion.SessionHelper objSession;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //objSession = clsManejoSesion.Login(txtUsuario.Text, txtContrasena.Text);
            //if (!objSession.isValid)
            //{
            //    errorProvider1.SetError(txtUsuario, objSession.msgError);
            //    txtUsuario.Focus();
            //    MessageBox.Show("ENTRE");
            //}
            //else
            //{
            //}
        }
    }
}
