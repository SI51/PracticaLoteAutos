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
    public partial class frmRoles : Form
    {

        public void LoadData()
        {
            this.dgvRoles.DataSource = Modelo.Rol.GetAll();
        }
        public frmRoles()
        {
            InitializeComponent();
            this.dgvRoles.AutoGenerateColumns = false;
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Vistas.frmNuevoRol nRol = new frmNuevoRol(this);
            nRol.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Modelo.Rol xRol = new Modelo.Rol();
            xRol.pkRol = int.Parse(dgvRoles.CurrentRow.Cells[0].Value.ToString());
            xRol.eliminarRol(xRol);
            LoadData();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRoles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
            Modelo.Rol miRol = new Modelo.Rol();
            

            miRol.pkRol = int.Parse(dgvRoles.CurrentRow.Cells[0].Value.ToString());
            miRol.sNombre = dgvRoles.CurrentRow.Cells[1].Value.ToString();
            miRol.sDescripcion = dgvRoles.CurrentRow.Cells[2].Value.ToString();
            miRol.bStatus = Convert.ToBoolean(dgvRoles.CurrentRow.Cells[3].Value.ToString());
       

            frmNuevoRol rolEditor = new frmNuevoRol(this, miRol);
            rolEditor.Show();
        }
    }
}
