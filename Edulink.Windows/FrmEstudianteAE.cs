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
    public partial class FrmEstudianteAE : Form
    {
        private Estudiante _estudiante;
        private readonly ServiciosEstudiantes _servicio;
        private bool _esEdicion = false;
        public FrmEstudianteAE()
        {
            InitializeComponent();
            _servicio = new ServiciosEstudiantes();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (_estudiante != null)
            {
                // ExamentextBox.Text = examen.Nombreexamen;
                _esEdicion = true;
            }
            txtContrasenia.Enabled = _esEdicion;
            cbEstado.Enabled = _esEdicion;
        }
        public Estudiante GetExamen()
        {
            return _estudiante;
        }

        public void SetExamen(Estudiante estudiante)
        {
            this._estudiante = estudiante;
        }

        private void InicializarControles()
        {
            //CategoriatextBox.Clear();
            //CategoriatextBox.Focus();
        }

        //TODO: validar datos
        private bool ValidadDatos()
        {
            bool validez = true;
            //errorProvider1.Clear();
            //if (string.IsNullOrEmpty(CategoriatextBox.Text))
            //{
            //    validez = false;
            //    errorProvider1.SetError(CategoriatextBox,
            //        "Debe ingresar el nombre de un pais");

            //}
            return validez;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //if (ValidadDatos())
            //{
            //    if (_estudiante == null)
            //    {
            //        categoria = new Categoria();
            //    }
            //    categoria.NombreCategoria = CategoriatextBox.Text;


            //    try
            //    {
            //        if (!_servicio.Existe(categoria))
            //        {
            //            _servicio.Guardar(categoria);

            //            if (!_esEdicion)
            //            {
            //                MessageBox.Show("Registro ingresado exitosamente", "Mensaje",
            //                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                DialogResult dr = MessageBox.Show("¿Desea agregar otro registro?",
            //                     "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            //                    MessageBoxDefaultButton.Button2);
            //                if (dr == DialogResult.No)
            //                {
            //                    DialogResult = DialogResult.OK;
            //                    return;
            //                }
            //                categoria = null;
            //                InicializarControles();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Registro editada exitosamente", "Mensaje",
            //                MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                DialogResult = DialogResult.OK;
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Error al ingresar la categoria, ya existe", "Mensaje",
            //                MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            InicializarControles();


            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Mensaje",
            //                MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
