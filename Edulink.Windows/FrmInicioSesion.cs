using EduLink.Entidades.Entidades;
using EduLink.Servicios.Interfaces;
using EduLink.Servicios.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edulink.Windows
{
    public partial class FrmInicioSesion : Form
    {
        private string _codigoAdmin;
        private string _contrasnia;
        private readonly IServiciosAdministradores _servicio;
        private int? _administradorId;
        public FrmInicioSesion()
        {
            _servicio= new ServiciosAdministradores();
            InitializeComponent();
        }

        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                _codigoAdmin = txtCodigo.Text;
                _contrasnia = txtContrasenia.Text;
                _administradorId = _servicio.ValidarInicioSesion(_codigoAdmin, _contrasnia);
                if (_administradorId != null)
                {
                    FrmCarrera frm = new FrmCarrera(_administradorId.Value);
                    frm.ShowDialog(this);

                }
                else
                {
                    MessageBox.Show("Código o contraseña incorrectos. Intente nuevamente.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                    errorProvider1.SetError(txtCodigo, "Debe ingresar un código válido");
                    validez = false;
                
            }
            if (string.IsNullOrWhiteSpace(txtContrasenia.Text))
            {
                
                    errorProvider1.SetError(txtCodigo, "Debe ingresar una contraseña válida");
                    validez = false;             

            }

            return validez;
        }
        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
