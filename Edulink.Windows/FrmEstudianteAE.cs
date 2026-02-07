using Edulink.Windows.Helpers;
using EduLink.Entidades.Entidades;
using EduLink.Entidades.Enums;
using EduLink.Servicios.Servicios;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Edulink.Windows
{
    public partial class FrmEstudianteAE : Form
    {
        private Estudiante _estudiante;
        private readonly ServiciosEstudianesExamen _servicio;
        private bool _esEdicion = false; // que útil que ha sido!!!!
        private int _carreraId;
        public FrmEstudianteAE(int carreraId)// Necesito el id de la carrera para setearlo en el estudiante nuevo
        {
            InitializeComponent();
            dtpFechaNacimiento.MinDate = new DateTime(1753, 1, 1);
            _servicio = new ServiciosEstudianesExamen();
            txtLegajo.Text = "El legajo se generará automáticamente";
            txtLegajo.Enabled = false;
            rbRegular.Checked = true;
            _carreraId = carreraId;
          
            ComboHelper.CargarComboCiudades(ref cbCiudad);
            ComboHelper.CargarComboCarreras(ref cbCarrera, null);
            
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (_estudiante != null)
            {
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
                dtpFechaNacimiento.Value = _estudiante.FechaNacimiento.Date;//controlar que no de error
                txtContrasenia.Text = _estudiante.Contrasenia;
                cbCiudad.SelectedValue = _estudiante.CiudadId;
                cbCarrera.SelectedValue = _estudiante.CarreraId;
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
            else
            {
                cbCarrera.SelectedValue = _carreraId;
               cbCarrera.Enabled = false;
            }
        }
        public Estudiante GetEstudiante()
        {
            return _estudiante;
        }

        public void SetEstudiante(Estudiante estudiante)
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
                _estudiante.Contrasenia = txtDNI.Text; // se settea la contraseña como el DNI por defecto cuando es nuevo
                if (_esEdicion)
                {
                    _estudiante.Contrasenia = txtContrasenia.Text; // cuando es edicion
                }
                _estudiante.FechaNacimiento = dtpFechaNacimiento.Value; // probar que pasa
                _estudiante.CiudadId = (int)cbCiudad.SelectedValue;
                _estudiante.CarreraId = (int)cbCarrera.SelectedValue;
                _estudiante.FechaAlta = DateTime.Now;
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


        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            // Ayuda a ver si no hay error al ingresar el DNI, y para saber cual es la contraseña por defecto
            if (!_esEdicion)
            {
                string texto = txtDNI.Text;
                if (texto.Length == 8) // un DNI tiene 8 caracteres
                {
                    txtContrasenia.Text = texto; // se lo agrega al txt de contraseña
                }
                else
                {
                    txtContrasenia.Clear(); // sino lo limpia para que vea que no se puso bien el DNI
                }
            }
        }

        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();

            //  &= es como un AND lógico, si alguna validación falla, validez será false
            // es como hacer validez = validez && ValidarTextBox...
            // Así se van acumulando los errores de validación
            // Como cuando se pone += para acumular valores,
            // por ejemplo: suma += valor; => suma = suma + valor;
            // en &= es lo mismo pero con valores booleanos,
            // por ejemplo: esValido &= condicion; => esValido = esValido && condicion;

            validez &= ValidarTextBox(txtNombres, "Debe ingresar el nombre del estudiante");
            validez &= ValidarTextBox(txtApellidos, "Debe ingresar el apellido del estudiante");
            validez &= ValidarTextBox(txtTelefono, "Debe ingresar el teléfono del estudiante");
            validez &= ValidarTextBox(txtEmail, "Debe ingresar el email del estudiante");
            validez &= ValidarTextBox(txtDireccion, "Debe ingresar la dirección del estudiante");
            validez &= ValidarTextBox(txtDNI, "Debe ingresar el DNI del estudiante");
            validez &= ValidarTextBox(txtContrasenia, "Debe ingresar la contraseña del estudiante");

            validez &= ValidarComboBox(cbCiudad, "Debe seleccionar una ciudad");
            validez &= ValidarComboBox(cbCarrera, "Debe seleccionar la carrera del estudiante");
            validez &= ValidarFecha(dtpFechaNacimiento, "La fecha de nacimiento debe ser posterior a 01/01/1753");

            if (!rbRegular.Checked && !rbLibre.Checked && !rbRecibido.Checked)
            {
                errorProvider1.SetError(rbRegular, "Debe seleccionar el estado del estudiante");
                validez = false;
            }
            if (_esEdicion)
            {
                if (!ValidarContrasenia(txtContrasenia.Text))
                {
                    errorProvider1.SetError(txtContrasenia,
                        "La contraseña debe tener al menos 8 caracteres, incluir letras, números y una mayúscula.");
                    validez = false;
                }
            }

            return validez;
        }


        private bool ValidarContrasenia(string contrasenia)
        {
            if (string.IsNullOrWhiteSpace(contrasenia)) return false;

            // Longitud mínima
            if (contrasenia.Length < 8) return false;

            // Debe tener al menos una mayúscula
            if (!contrasenia.Any(char.IsUpper)) return false;

            // Debe tener al menos una letra
            if (!contrasenia.Any(char.IsLetter)) return false;

            // Debe tener al menos un número
            if (!contrasenia.Any(char.IsDigit)) return false;

            return true;
        }

        private bool ValidarTextBox(TextBox txt, string mensaje)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                errorProvider1.SetError(txt, mensaje);
                return false;
            }
            errorProvider1.SetError(txt, string.Empty);
            return true;
        }

        private bool ValidarComboBox(ComboBox cb, string mensaje)
        {
            if (cb.SelectedIndex <= 0)
            {
                errorProvider1.SetError(cb, mensaje);
                return false;
            }
            errorProvider1.SetError(cb, string.Empty);
            return true;
        }

        private bool ValidarFecha(DateTimePicker dtp, string mensaje)
        {
            if (dtp.Value < new DateTime(1753, 1, 1))
            {
                errorProvider1.SetError(dtp, mensaje);
                return false;
            }
            errorProvider1.SetError(dtp, string.Empty);
            return true;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}