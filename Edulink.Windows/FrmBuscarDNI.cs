using EduLink.Servicios.Servicios;
using System;
using System.Windows.Forms;

namespace Edulink.Windows
{
    public partial class FrmBuscarDNI : Form
    {
        private int _DNI;
        private readonly ServiciosEstudiantes _servicio;
        public FrmBuscarDNI()
        {
            InitializeComponent();
        }

        public int GetDNI()
        {
            return _DNI;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                _DNI = int.Parse(txtDNI.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                txtDNI.SelectAll();
                txtDNI.Focus();
            }
        }
        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtDNI.Text) || txtDNI.Text.Length != 8)
            {
                errorProvider1.SetError(txtDNI, "Debe ingresar un DNI válido");
                return false;

            }
           
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}