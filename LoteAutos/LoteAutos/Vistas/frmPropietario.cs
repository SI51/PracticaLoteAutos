using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace LoteAutos.Vistas
{
    public partial class frmPropietario : Form
    {

        public static string rows;
        public void LoadData()
        {
            this.dgvPropietario.DataSource = Modelo.Propietario.GetAll();

        }
        public frmPropietario()
        {
            InitializeComponent();
            this.dgvPropietario.AutoGenerateColumns = false;
        }

        private void frmPropietario_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Vistas.frmNuevoPropietario nPro = new frmNuevoPropietario(this);
            nPro.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Modelo.Propietario xpro = new Modelo.Propietario();
            xpro.pkPropietario = int.Parse(dgvPropietario.CurrentRow.Cells[0].Value.ToString());
            xpro.eliminarPropietario(xpro);
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
