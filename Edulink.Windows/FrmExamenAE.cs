using Edulink.Windows.Helpers;
using EduLink.Entidades.Entidades;
using EduLink.Servicios.Servicios;
using System;
using System.Windows.Forms;

namespace Edulink.Windows
{
    public partial class FrmExamenAE : Form
    {

        // cambiar todo
        private int _carreraId;
        private Examen _examen;
        private readonly ServiciosEstudiantesExamenes _servicio;
        private bool _esEdicion = false;
        public FrmExamenAE(int carreraId)
        {
            InitializeComponent();
            _servicio = new ServiciosEstudiantesExamenes();

            _carreraId = carreraId;
            ComboHelper.CargarComboMaterias(ref cbMateria, _carreraId);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (_examen != null)
            {
                // ExamentextBox.Text = examen.Nombreexamen;
                _esEdicion = true;
            }
        }
        internal Examen GetExamen()
        {
            return _examen;
        }

        internal void SetExamen(Examen examen)
        {
            this._examen = examen;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (_examen == null)
                {
                    _examen = new Examen();
                }
                _examen.MateriaId = (int)cbMateria.SelectedValue;
                _examen.FechaExamen = dtpFechaExamen.Value;
                _examen.HoraComienzo = dtpHoraExamen.Value.TimeOfDay;

                try
                {
                    if (!_servicio.Existe(_examen))
                    {
                        _servicio.Guardar(_examen);

                        if (!_esEdicion)
                        {
                            MessageBox.Show("Examen ingresado exitosamente", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DialogResult dr = MessageBox.Show("¿Desea agregar otro examen?",
                                "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2);

                            if (dr == DialogResult.No)
                            {
                                DialogResult = DialogResult.OK;
                                return;
                            }

                            _examen = null;
                            InicializarControles();
                        }
                        else
                        {
                            MessageBox.Show("Examen editado exitosamente", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: el examen ya existe", "Mensaje",
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
        private void InicializarControles()
        {
            cbMateria.SelectedIndex = -1; // ver que onda
            dtpFechaExamen.Value = DateTime.Today;
            dtpHoraExamen.Value = DateTime.Today;
        }
        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();
            if (cbMateria.SelectedIndex <= 0)
            {
                errorProvider1.SetError(cbMateria, "Debe seleccionar una materia");
                return false;
            }

            if (dtpFechaExamen.Value < new DateTime(1753, 1, 1))
            {
                errorProvider1.SetError(dtpFechaExamen, "Fecha inavalida");
                return false;
            }

            return validez;
        }





        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
