using Edulink.Windows.Helpers;
using EduLink.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edulink.Windows
{
    public partial class FrmBuscarCiudad : Form
    {        
        private int _ciudadId;
        public FrmBuscarCiudad()
        {
            InitializeComponent();
            
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ComboHelper.CargarComboCiudades(ref cbCiudad);
            
        }
        public int GetCiudad()
        {
            return _ciudadId;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                _ciudadId = (int)cbCiudad.SelectedValue;
                DialogResult = DialogResult.OK;
            }
            
        }
        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();

            if (cbCiudad.SelectedIndex <= 0)
            {
                errorProvider1.SetError(cbCiudad, "Debe seleccionar una ciudad");
                return false;
            }
            errorProvider1.SetError(cbCiudad, string.Empty);
            return true; 
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
