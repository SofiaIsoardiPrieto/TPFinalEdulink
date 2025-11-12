using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
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
    public partial class FrmExamenAE : Form
    {

        // cambiar todo

        private EstudianteDto estudianteDto;
        private readonly ServiciosEstudiantes _servicio;
        private bool esEdicion = false;
        public FrmExamenAE()
        {
            InitializeComponent();
            _servicio= new ServiciosEstudiantes();
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
        internal EstudianteDto GetExamen()
        {
            return estudianteDto;
        }

        internal void SetExamen(EstudianteDto estudianteDto)
        {
           this.estudianteDto=estudianteDto;
        }

        private void FrmEstudianteAE_Load(object sender, EventArgs e)
        {

        }
    }
}
