using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoteAutos.Modelo;

namespace LoteAutos.Vistas
{
    public partial class frmCompradores : Form
    {       
        public void LoadData()
        {
            this.dgvDatosComprador.DataSource = Comprador.GetAll();
        }
        public frmCompradores()
        {
            InitializeComponent();
        }

        private void frmCompradores_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevoComprador NuComprador = new frmNuevoComprador(this);
            NuComprador.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Comprador eli = new Comprador();
            eli.pkComprador=int.Parse(dgvDatosComprador.CurrentRow.Cells[0].Value.ToString());
            eli.eli(eli);
            LoadData();        
        }
            
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FILTRAR BUSCAR = new FILTRAR();
            this.dgvDatosComprador.DataSource = Comprador.Buscar(BUSCAR, txtBuscar.Text);
        }

        private void dgvDatosComprador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDatosComprador_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Comprador micomprador = new Comprador();

            micomprador.pkComprador=int.Parse(dgvDatosComprador.CurrentRow.Cells[0].Value.ToString());
            micomprador.sNombre = dgvDatosComprador.CurrentRow.Cells[1].Value.ToString();
            micomprador.sApePaterno = dgvDatosComprador.CurrentRow.Cells[2].Value.ToString();
            micomprador.sApeMaterno = dgvDatosComprador.CurrentRow.Cells[3].Value.ToString();
            micomprador.sCalle = dgvDatosComprador.CurrentRow.Cells[4].Value.ToString();
            micomprador.iNumero = int.Parse(dgvDatosComprador.CurrentRow.Cells[5].Value.ToString());
            micomprador.sColonia = dgvDatosComprador.CurrentRow.Cells[6].Value.ToString();
            micomprador.sCiudad = dgvDatosComprador.CurrentRow.Cells[7].Value.ToString();
            
            frmNuevoComprador xs = new frmNuevoComprador(this,micomprador);
            xs.Show();        
       
        }
    }
}
