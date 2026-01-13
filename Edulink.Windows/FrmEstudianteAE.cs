using Edulink.Windows.Helpers;
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
        private int _carreraId;
        public FrmEstudianteAE(int carreraId)
        {
            InitializeComponent();
            dtpFechaNacimiento.MinDate = new DateTime(1753, 1, 1);
            _servicio = new ServiciosEstudiantes();
            txtLegajo.Text = "El legajo se generará automáticamente";
            txtLegajo.Enabled = false;
            rbRegular.Checked = true;
            _carreraId = carreraId;
            cbCarrera.Enabled = false;
            ComboHelper.CargarComboCiudades(ref cbCiudad);
            ComboHelper.CargarComboCarreras(ref cbCarrera, null);
            cbCarrera.SelectedValue = carreraId;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (_estudiante != null)
            {
                
                _estudiante.CarreraId = _carreraId;
                cbCarrera.Enabled = true;
              
                // ExamentextBox.Text = examen.Nombreexamen;
                _esEdicion = true;
                txtContrasenia.Enabled = _esEdicion;
                txtLegajo.Text = _estudiante.Legajo.ToString();
                txtNombres.Text = _estudiante.Nombres;
                txtApellidos.Text = _estudiante.Apellidos;
                txtDireccion.Text = _estudiante.Direccion;
                txtTelefono.Text = _estudiante.Telefono;
                txtDNI.Text = _estudiante.DNI;
                txtEmail.Text = _estudiante.Email;
                dtpFechaNacimiento.Value=_estudiante.FechaNacimiento;
                txtContrasenia.Text = _estudiante.Contrasenia;
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
            txtNombres.Clear();
            txtNombres.Focus();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtDNI.Clear();
            txtEmail.Clear();
            txtContrasenia.Clear();
            cbCiudad.SelectedIndex = -1;
            cbCarrera.SelectedIndex = _carreraId; // ver que onda
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
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                validez = false;
                errorProvider1.SetError(txtEmail,
                    "Debe ingresar el email del estudiante");

            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                validez = false;
                errorProvider1.SetError(txtDireccion,
                    "Debe ingresar el dirección del estudiante");

            }
            if (string.IsNullOrEmpty(txtDNI.Text) || txtDNI.TextLength != 8)
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
            if (cbCiudad.SelectedIndex == 0)
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
            } // no es necesario?
            if (cbCarrera.SelectedIndex == -1)
            {
                validez = false;
                errorProvider1.SetError(cbCarrera,
                    "Debe seleccionar la carrera del estudiante");
            }
            else
            {
                errorProvider1.SetError(cbCarrera, string.Empty);
            }// no es necesario
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
                _estudiante.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                _estudiante.CiudadId = (int)cbCiudad.SelectedValue;
                _estudiante.CarreraId = _carreraId;

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

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            string texto = txtDNI.Text;
            if (texto.Length == 8)
            {
                txtContrasenia.Text = texto; // cheakear
            }
            else
            {
                txtContrasenia.Clear();
            }
        }
    }
}