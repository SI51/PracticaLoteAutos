using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;

namespace LoteAutos.Vistas
{
    public partial class frmNuevoPropietario : Form
    {
        string filename;
        VideoCaptureDevice capturar;

        frmPropietario propietario;

        public frmNuevoPropietario(frmPropietario xpropietario)
        {
            InitializeComponent();

            propietario = xpropietario;
        }      

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FilterInfoCollection info = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (info != null)
            {
                capturar = new VideoCaptureDevice(info[0].MonikerString);
                capturar.NewFrame += (s, i) => prbFoto.Image = (Bitmap)i.Frame.Clone();
                capturar.Start();
            }

        }

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {
            capturar.Stop();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        public void guardarfoto()
        {
            string num = "foto" + frmPropietario.rows + ".png"  ;
            filename = @"C:\Users\Luis-PC\Documents\5to Cuatri\Noe\1.1\LoteAutos\FotosPropientario\" + num.ToString();
            FileStream fstream = new FileStream(filename, FileMode.Create);
            this.prbFoto.Image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            fstream.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Modelo.Propietario pro = new Modelo.Propietario();

            pro.sNombre = txtNombre.Text;
            pro.sApePaterno = txtApellidoPaterno.Text;
            pro.sApeMaterno = txtApellidoMaterno.Text;
            pro.sCalle = txtCalle.Text;
            pro.iNumero = Convert.ToInt32(txtNumero.Text);
            pro.sColonia = txtColonia.Text;
            pro.sCiudad = txtCiudad.Text;
            pro.sTelefono = txtTelefono.Text;
            pro.sEmail = txtEmail.Text;
            pro.sIfe = txtIFE.Text;
            this.guardarfoto();
            pro.sFoto = filename;



            pro.AgregarEditar(pro);
            propietario.LoadData();          
            this.Close();
        }
    }
}
