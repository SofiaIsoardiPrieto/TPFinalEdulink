using EduLink.Servicios.Servicios;
using System;
using System.Windows.Forms;

namespace Edulink.Windows
{
    public partial class FrmBuscarLegajo : Form
    {
        private int _legajo;
        private readonly ServiciosEstudiantes _servicio;
        public FrmBuscarLegajo()
        {
            InitializeComponent();
        }

        public int GetLegajo()
        {
            return _legajo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                _legajo = int.Parse(txtLegajo.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                txtLegajo.SelectAll();
                txtLegajo.Focus();
            }
        }
        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtLegajo.Text))
            {
                errorProvider1.SetError(txtLegajo, "Debe ingresar un Legajo válido");
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