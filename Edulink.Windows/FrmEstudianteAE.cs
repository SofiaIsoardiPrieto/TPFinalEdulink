using EduLink.Entidades.Dtos;
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
    public partial class FrmEstudianteAE : Form
    {
        private EstudianteDto estudianteDto;
        private readonly ServiciosEstudiantes _servicio;
        private bool esEdicion = false;
        public FrmEstudianteAE()
        {
            InitializeComponent();
            _servicio = new ServiciosEstudiantes();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (estudianteDto != null)
            {
                // ExamentextBox.Text = examen.Nombreexamen;
                esEdicion = true;
            }
        }
        public EstudianteDto GetExamen()
        {
            return estudianteDto;
        }

        public void SetExamen(EstudianteDto estudianteDto)
        {
            this.estudianteDto = estudianteDto;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
