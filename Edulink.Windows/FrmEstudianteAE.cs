using EduLink.Entidades.Entidades;
using EduLink.Entidades.Enums;
using EduLink.Servicios.Servicios;
using System;
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
            txtLegajo.Text = "El legajo se generará automáticamente cuando se cree el alumno";
            rbRegular.Checked = true;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (_estudiante != null)
            {
                // ExamentextBox.Text = examen.Nombreexamen;
                _esEdicion = true;
                txtContrasenia.Enabled = _esEdicion;
                rbRegular.Enabled = true;
                rbLibre.Enabled = true;
                rbRegular.Enabled = true;
                txtLegajo.Text = _estudiante.Legajo.ToString();
                txtNombres.Text = _estudiante.Nombres;
                txtApellidos.Text = _estudiante.Nombres;
                txtDireccion.Text = _estudiante.Nombres;
                txtTelefono.Text = _estudiante.Nombres;
                txtDNI.Text = _estudiante.Nombres;
                txtEmail.Text = _estudiante.Nombres;
                txtContrasenia.Text = _estudiante.Nombres;
                cbCiudad.SelectedValue = _estudiante.CiudadId;
                if (_estudiante.EstadoEstudiante == EstadoEstudiante.Regular)
                {
                    rbRegular.Checked = true;
                }
                else if (_estudiante.EstadoEstudiante == EstadoEstudiante.Libre)
                {
                    rbLibre.Checked = true;
                }
                else if (_estudiante.EstadoEstudiante == EstadoEstudiante.Recibido)
                {
                    rbRecibido.Checked = true;
                }
            }


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
        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();
            //if (string.IsNullOrEmpty(txtLegajo.Text)) // No se asigna legajo manualmente ni se puede editar
            //{
            //    validez = false;
            //    errorProvider1.SetError(txtLegajo,
            //        "Debe ingresar el legajo del estudiante");

            //}
            if (string.IsNullOrEmpty(txtNombres.Text))
            {
                validez = false;
                errorProvider1.SetError(txtNombres,
                    "Debe ingresar el nombre del estudiante");

            }
            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                validez = false;
                errorProvider1.SetError(txtApellidos,
                    "Debe ingresar el apellido del estudiante");

            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                validez = false;
                errorProvider1.SetError(txtTelefono,
                    "Debe ingresar el teléfono del estudiante");

            }
            if (string.IsNullOrEmpty(txtDNI.Text))
            {
                validez = false;
                errorProvider1.SetError(txtDNI,
                    "Debe ingresar el DNI del estudiante");

            }
            if (string.IsNullOrEmpty(txtContrasenia.Text))// nuevo: se asigna contraseña automática, pero se puede editar
            {
                validez = false;
                errorProvider1.SetError(txtContrasenia,
                    "Debe ingresar la contraseña del estudiante");

            }
            if (cbCiudad.SelectedIndex == -1)
            {
                validez = false; 
                errorProvider1.SetError(cbCiudad, "Debe seleccionar una cuidad");
            }
            else
            {
                errorProvider1.SetError(cbCiudad, string.Empty);
            }
            // Estado estudiante
            // nuevo: se fija Regular, editar para cambiar de Libre a Regular o recibido
            if (!rbRegular.Checked && !rbLibre.Checked && !rbRecibido.Checked)
            {
                validez = false;
                errorProvider1.SetError(rbRegular,
                    "Debe seleccionar el estado del estudiante");
            } // no es necesario

            return validez;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (_estudiante == null)
                {
                    _estudiante = new Estudiante();
                }

                // Legajo se genera automáticamente en el la base de datos al crear el estudiante
                // Mapear datos desde los controles al objeto
                _estudiante.Nombres = txtNombres.Text;
                _estudiante.Apellidos = txtApellidos.Text;
                _estudiante.Direccion = txtDireccion.Text;
                _estudiante.Telefono = txtTelefono.Text;
                _estudiante.DNI = txtDNI.Text;
                _estudiante.Email = txtEmail.Text;
                _estudiante.Contrasenia = txtDNI.Text; // se settea la contraseña como el DNI por defecto
                _estudiante.CiudadId = (int)cbCiudad.SelectedValue;

                // Estado con RadioButtons
                if (rbRegular.Checked)
                    _estudiante.EstadoEstudiante = EstadoEstudiante.Regular;
                else if (rbLibre.Checked)
                    _estudiante.EstadoEstudiante = EstadoEstudiante.Libre;
                else if (rbRecibido.Checked)
                    _estudiante.EstadoEstudiante = EstadoEstudiante.Recibido;

                try
                {
                    if (!_servicio.Existe(_estudiante))
                    {
                        _servicio.Guardar(_estudiante);

                        if (!_esEdicion)
                        {
                            MessageBox.Show("Estudiante ingresado exitosamente", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DialogResult dr = MessageBox.Show("¿Desea agregar otro estudiante?",
                                "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2);

                            if (dr == DialogResult.No)
                            {
                                DialogResult = DialogResult.OK;
                                return;
                            }

                            _estudiante = null;
                            InicializarControles();
                        }
                        else
                        {
                            MessageBox.Show("Estudiante editado exitosamente", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: el estudiante ya existe", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        InicializarControles();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
