using EduLink.Servicios.Servicios;
using System;
using System.Windows.Forms;

namespace Edulink.Windows
{
    public partial class FrmBuscarEdad : Form
    {
        private int _edadMin;
        private int _edadMax;
      //  private readonly ServiciosEstudiantes _servicioEstudiantes;
        public FrmBuscarEdad()
        {
            InitializeComponent();
            txtEdadMin.Focus();
        }

        public int GetEdadMin()
        {
            return _edadMin;
        }
        public int GetEdadMax()
        {
            return _edadMax;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                _edadMin = int.Parse(txtEdadMin.Text);
                _edadMax = int.Parse(txtEdadMax.Text);
                DialogResult = DialogResult.OK;
            }
            
        }
        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();

            if (!int.TryParse(txtEdadMin.Text,  out int min ))
            {
                if (min < 0)
                {
                    errorProvider1.SetError(txtEdadMin, "Debe ingresar una edad mínima válida");
                    validez = false;
                }

            }
            if (!int.TryParse(txtEdadMax.Text, out int max))
            {
                if (max < min)
                {
                    errorProvider1.SetError(txtEdadMax, "Debe ingresar una edad máxima válida");
                    validez = false;
                }

            }

            return validez;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}