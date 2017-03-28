using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoteAutos.Vistas
{
    public partial class frmNuevoRol : Form
    {
        frmRoles rol;
        Modelo.Rol xROL;

        public frmNuevoRol(frmRoles Rol)
        {
            InitializeComponent();
            rol = Rol;
        }

        public frmNuevoRol(frmRoles Rol, Modelo.Rol xRol)
        {
            InitializeComponent();
            this.Text = "Editar Rol";
            xROL = xRol;
            txtNombre.Text = xRol.sNombre;
            txtDescripcion.Text = xRol.sDescripcion;
            chkEstado.Checked = xRol.bStatus;
            

            rol = Rol;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Modelo.Rol roles;
            if (xROL == null)
            {
                roles = new Modelo.Rol();
            }
            else
            {
                roles = xROL;
            }

            //Modelo.Rol roles = new Modelo.Rol();

            roles.sNombre = txtNombre.Text;
            roles.sDescripcion = txtDescripcion.Text;
            roles.bStatus = false;

            if (chkEstado.Checked == true)
            {
                roles.bStatus = true;
            }

            roles.AgregarEditar(roles);
            rol.LoadData();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
