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
    public partial class FrmCarrera : Form
    {
        private int _adminId;
        public FrmCarrera(int adminId)
        {
            InitializeComponent();
            _adminId = adminId;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ComboHelper.CargarComboCarreras(ref cbCarrera,  _adminId);
            
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cbCarrera.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una carrera", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Recuperar el valor seleccionado (CarreraId)
            int carreraId = (int)cbCarrera.SelectedValue;

            // Pasar el id al siguiente formulario
            FrmMenuPrincipal frm = new FrmMenuPrincipal(carreraId);
            frm.ShowDialog();
        }


        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

        }
    }
}
