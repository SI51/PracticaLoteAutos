using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoteAutos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCompradores_Click(object sender, EventArgs e)
        {
            Vistas.frmCompradores comprador = new Vistas.frmCompradores();
            comprador.Show();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            Vistas.frmRoles rol = new Vistas.frmRoles();
            rol.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vistas.frmPropietario pro = new Vistas.frmPropietario();
            pro.Show();
        }
    }
}
