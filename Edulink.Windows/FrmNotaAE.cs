using EduLink.Servicios.Servicios;
using System;
using System.Windows.Forms;

namespace Edulink.Windows
{
    public partial class FrmNotaAE : Form
    {
        private int _nota;
        private readonly ServiciosEstudianesExamen _servicio;
        public FrmNotaAE()
        {
            InitializeComponent();
        }

        public int Getnota()
        {
            return _nota;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                _nota = int.Parse(txtNota.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                txtNota.SelectAll();
                txtNota.Focus();
            }
        }
        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();

            int nota;
            if (!int.TryParse(txtNota.Text, out nota))
            {
                errorProvider1.SetError(txtNota, "Debe ingresar un número entero");
                validez = false;
            }
            else if (nota < 0 || nota > 10)
            {
                errorProvider1.SetError(txtNota, "La nota debe estar entre 0 y 10");
                validez = false;
            }

            return validez;
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}