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
    public partial class FrmMenuPrincipal : Form
    {
        private int _carreraId;
       
        public FrmMenuPrincipal(int carreraId, string nombreCarrera)
        {
            InitializeComponent();
            _carreraId = carreraId;
            lblNombreCarrera.Text = $"{nombreCarrera}";
            
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            FrmEstudiantes frm = new FrmEstudiantes(_carreraId);
            frm.ShowDialog();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            FrmMaterias frm = new FrmMaterias(_carreraId);
            frm.ShowDialog();
        }

        private void btnExamenes_Click(object sender, EventArgs e)
        {
            FrmExamenes frm = new FrmExamenes(_carreraId);
            frm.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
