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
    public partial class frmNuevoComprador : Form
    {
        frmCompradores xMAIN;
        Comprador comprador;

        public frmNuevoComprador(frmCompradores xmain)
        {
            InitializeComponent();
            xMAIN = xmain;
        }

        public frmNuevoComprador(frmCompradores xmain, Comprador mil)
        {
            InitializeComponent();

            this.Text = "Editar Comprador";
            comprador = mil;
            txtNombre.Text = mil.sNombre;
            txtApellidoPaterno.Text = mil.sApePaterno;
            txtApellidoMaterno.Text = mil.sApeMaterno;
            txtCalle.Text = mil.sCalle;
            txtNumero.Text = ""+mil.iNumero;
            txtColonia.Text = mil.sColonia;
            txtCiudad.Text = mil.sCiudad;
            xMAIN = xmain;

        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Comprador nCcomprador;
            if (comprador==null)
            {
                nCcomprador = new Comprador();
            }
            else
            {
                nCcomprador = comprador;
            }

            //Comprador nCcomprador = new Comprador();
            nCcomprador.sNombre = txtNombre.Text;
            nCcomprador.sApePaterno = txtApellidoPaterno.Text;
            nCcomprador.sApeMaterno = txtApellidoMaterno.Text;
            nCcomprador.sCalle = txtCalle.Text;
            nCcomprador.iNumero = Convert.ToInt16(txtNumero.Text);
            nCcomprador.sColonia = txtColonia.Text;
            nCcomprador.sCiudad = txtCiudad.Text;
            nCcomprador.Guardar(nCcomprador);
            
            xMAIN.LoadData();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente quiere salir de la ventana?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmNuevoComprador_Load(object sender, EventArgs e)
        {

        }
    }
}
