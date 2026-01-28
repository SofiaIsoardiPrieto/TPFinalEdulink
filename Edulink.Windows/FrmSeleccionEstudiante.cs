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
    public partial class FrmSeleccionEstudiante : Form
    {
        private int _estudianteId;
        private bool _inscripcion;
        private int _carreraId;

        public FrmSeleccionEstudiante(int carreraId, int estudianteId, bool inscripcion)
        {
            InitializeComponent();
           _inscripcion=inscripcion;
            _estudianteId =estudianteId;
            _carreraId = carreraId;
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            if ( _inscripcion)
            {
                FrmInscripcionMaterias frm = new FrmInscripcionMaterias(_estudianteId);
                frm.ShowDialog();
            }
            else
            {
                // el otro form de historial de materias
            }
        }

        private void btnExamenes_Click(object sender, EventArgs e)
        {
            if (_inscripcion)
            {
                FrmInscripcionExamenes frm = new FrmInscripcionExamenes(_estudianteId);
                frm.ShowDialog();
            }
            else
            {
                // el otro form de historial de examenes
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmEstudiantes frm = new FrmEstudiantes(_carreraId);
            frm.ShowDialog();
        }
    }
}
