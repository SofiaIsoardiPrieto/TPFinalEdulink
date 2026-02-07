using Edulink.Windows.Helpers;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using EduLink.Entidades.Enums;
using EduLink.Servicios.Interfaces;
using EduLink.Servicios.Servicios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Edulink.Windows
{
    public partial class FrmEstudiantes : Form
    {
        // Se usa readonly para asegurar que no se reasigne fuera del constructor.
        private readonly IServiciosEstudiantes _servicioEstudiante;
        private readonly IServiciosCarreras _servicioCarreras;
        private List<EstudianteDto> _lista;
        private int _carreraId;
        private int _paginaActual = 1; // Número de página actual en la paginación. Se inicia en la primera página.
        private int _registrosTotales;
        private int _paginasTotales; // Cantidad total de páginas calculadas en base a los registros disponibles.
        private int _registrosPorPagina = 5; // Cantidad de registros que se mostrarán por página.
        private bool _filterOn = false; // por lo pronto no lo necesito
        private EstadoEstudiante? _estadoEstudiante;
        private int? _edadMin;
        private int? _edadMax;
        private int? _anioAlta;
        private int? _ciudadId;

        public FrmEstudiantes(int carreraId)
        {
            InitializeComponent(); // Inicializa los controles del formulario.
            _servicioEstudiante = new ServiciosEstudianesExamen(); // Se instancia el servicio concreto.
            // ¿Sería útil usar inyección de dependencias para mayor flexibilidad?
            _carreraId = carreraId;
            _servicioCarreras = new ServiciosCarreras();
        }

        private void FrmEstudiantes_Load(object sender, EventArgs e)
        {
            if (_servicioEstudiante is null) // comprueba que el servicio se haya inicializado correctamente.
            {
                MessageBox.Show("Habilitar el servicio de SQL", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RecargarGrilla();
        }
        /// <summary>
        /// Actualiza los datos de la grilla de estudiantes aplicando lógica de paginación.
        /// Obtiene la cantidad total de registros desde el servicio, calcula el número de páginas
        /// y muestra los datos correspondientes a la página actual.
        /// </summary>
        private void RecargarGrilla()
        {
            try
            {
                _registrosTotales = _servicioEstudiante.GetCantidad(_carreraId, _edadMin, _edadMax, _anioAlta, _ciudadId, _estadoEstudiante.ToString());// obtiene la cantidad total de registros.
                _paginasTotales = FormHelper.CalcularPaginas(_registrosTotales, _registrosPorPagina);// calcula el total de páginas.
                MostrarPaginado();
            }
            catch (Exception) { throw; }
        }
        /// <summary>
        /// Carga y muestra los datos de estudiantes correspondientes a la página actual.
        /// </summary>
        private void MostrarPaginado()
        {
            _lista = _servicioEstudiante.GetEstudiantesPorPagina(_carreraId, _registrosPorPagina, _paginaActual, _edadMin, _edadMax, _anioAlta, _ciudadId, _estadoEstudiante.ToString());
            MostrarDatosEnGrilla();
        }
        /// <summary>
        /// Popula la grilla con los datos de estudiantes.
        /// </summary>
        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatosEstudiantes);
            foreach (var estudianteDto in _lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvDatosEstudiantes);
                GridHelper.SetearFila(r, estudianteDto);
                GridHelper.AgregarFila(dgvDatosEstudiantes, r);
            }

            lblPaginaActual.Text = _paginaActual.ToString();
            lblPaginasTotales.Text = _paginasTotales.ToString();
            lblRegistros.Text = _registrosTotales.ToString();
            ActualizarBotonesPaginado();

        }
        /// <summary>
        /// Actualiza el estado (habilitado/deshabilitado) de los botones de paginación
        /// </summary>
        private void ActualizarBotonesPaginado()
        {
            if (_registrosTotales <= _registrosPorPagina)
            {
                btnPrimero.Enabled = false;
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
                return;
            }
            if (_paginaActual == _paginasTotales)
            {
                btnPrimero.Enabled = true;
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
            }
            if (_paginaActual < _paginasTotales)
            {
                btnPrimero.Enabled = true;
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }
            if (_paginaActual > _paginasTotales)
            {
                btnPrimero.Enabled = true;
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }
            if (_paginaActual == 1)
            {
                btnPrimero.Enabled = false;
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }

        }
        /// <summary>
        /// Limpia los filtros aplicados y actualiza la lista de estudiantes.
        /// </summary>
        private void LimpiarBotonesYActualizarLista()
        {
            _filterOn = false;
            _estadoEstudiante = null;
            _edadMin = null;
            _edadMax = null;
            _anioAlta = null;
            _ciudadId = null;

            edadToolStripMenuItem.BackColor = Color.FromArgb(249, 245, 253); // color base
            regularToolStripMenuItem.BackColor = Color.FromArgb(249, 245, 253); // color base
            libreToolStripMenuItem.BackColor = Color.FromArgb(249, 245, 253); // color base
            recibidoToolStripMenuItem.BackColor = Color.FromArgb(249, 245, 253); // color base
            CiudadToolStripMenuItem.BackColor = Color.FromArgb(249, 245, 253); // color base
            dNIToolStripMenuItem.BackColor = Color.FromArgb(249, 245, 253); // color base
            legajoToolStripMenuItem.BackColor = Color.FromArgb(249, 245, 253); // color base
            FechaIngresoToolStripMenuItem.BackColor = Color.FromArgb(249, 245, 253); // color base

            RecargarGrilla();
        }
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            _paginaActual = 1;
            lblPaginaActual.Text = (_paginaActual).ToString();
            MostrarPaginado();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            _paginaActual--;
            if (_paginaActual == 1)
            {
                btnAnterior.Enabled = false;
                btnPrimero.Enabled = false;
            }
            lblPaginaActual.Text = (_paginaActual).ToString();
            MostrarPaginado();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            _paginaActual++;
            if (_paginaActual == _paginasTotales)
            {
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;

            }
            lblPaginaActual.Text = (_paginaActual).ToString();
            MostrarPaginado();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            _paginaActual = _paginasTotales;
            lblPaginaActual.Text = (_paginaActual).ToString();
            MostrarPaginado();
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            FrmEstudianteAE frm = new FrmEstudianteAE(_carreraId);
            DialogResult dr = frm.ShowDialog(this);
            RecargarGrilla();
            MostrarDatosEnGrilla();
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatosEstudiantes.SelectedRows.Count == 0) { return; }
            var r = dgvDatosEstudiantes.SelectedRows[0];
            EstudianteDto estudianteDto = (EstudianteDto)r.Tag;
            EstudianteDto estudianteDtoCopia = (EstudianteDto)estudianteDto.Clone();
            Estudiante estudiante = _servicioEstudiante.GetEstudiantePorId(estudianteDto.EstudianteId);
            try
            {
                FrmEstudianteAE frm = new FrmEstudianteAE(_carreraId) { Text = "Editar Estudiante" };
                frm.SetEstudiante(estudiante);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    GridHelper.SetearFila(r, estudianteDtoCopia);
                    return;
                }
                estudiante = frm.GetEstudiante();
                if (estudianteDto != null)
                {
                    GridHelper.SetearFila(r, estudianteDto);
                }
                else
                {
                    GridHelper.SetearFila(r, estudianteDtoCopia);
                }
                RecargarGrilla();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {
                GridHelper.SetearFila(r, estudianteDtoCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatosEstudiantes.SelectedRows.Count == 0) return;
            var r = dgvDatosEstudiantes.SelectedRows[0];
            EstudianteDto estudianteDto = (EstudianteDto)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea dar de baja el registro seleccionado?", // Se le pone como alumno libre
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                if (!_servicioEstudiante.EstaRelacionado(estudianteDto.EstudianteId))// Veo si el estudiante esta en otras tablas, problema de FK
                {
                    _servicioEstudiante.Borrar(estudianteDto.EstudianteId);
                    GridHelper.QuitarFila(dgvDatosEstudiantes, r);
                    _registrosTotales = _servicioEstudiante.GetCantidad(_carreraId);
                    _paginasTotales = FormHelper.CalcularPaginas(_registrosTotales, _registrosPorPagina);
                    lblRegistros.Text = _registrosTotales.ToString();
                    lblPaginasTotales.Text = _paginasTotales.ToString();
                    MessageBox.Show("Estudiante en condición de libre", "Mensaje", // Esto como afecta finales o cursadas?
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarGrilla();
                    MostrarDatosEnGrilla();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tsActualizar_Click(object sender, EventArgs e)
        {
            LimpiarBotonesYActualizarLista();
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _filterOn = true;
            _estadoEstudiante = EstadoEstudiante.Regular;
            regularToolStripMenuItem.BackColor = Color.FromArgb(230, 230, 250);
            RecargarGrilla();
        }

        private void libreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _filterOn = true;
            _estadoEstudiante = EstadoEstudiante.Libre;
            libreToolStripMenuItem.BackColor = Color.FromArgb(230, 230, 250);
            RecargarGrilla();
        }

        private void recibidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _filterOn = true;
            _estadoEstudiante = EstadoEstudiante.Recibido;
            recibidoToolStripMenuItem.BackColor = Color.FromArgb(230, 230, 250);
            RecargarGrilla();
        }

        private void edadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarEdad frm = new FrmBuscarEdad();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            edadToolStripMenuItem.BackColor = Color.FromArgb(230, 230, 250);
            _filterOn = true;
            _edadMin = frm.GetEdadMin();
            _edadMax = frm.GetEdadMax();
            RecargarGrilla();
        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarCiudad frm = new FrmBuscarCiudad();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            CiudadToolStripMenuItem.BackColor = Color.FromArgb(230, 230, 250);
            _filterOn = true;
            _ciudadId = frm.GetCiudad();
            RecargarGrilla();
        }
        private void legajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarLegajo frm = new FrmBuscarLegajo();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;

            int legajo = frm.GetLegajo();
            EstudianteDto estudianteDto = _servicioEstudiante.GetEstudiantePorLegajo(legajo);

            if (estudianteDto != null)
            {
                _lista = new List<EstudianteDto> { estudianteDto }; // solo ese estudiante
                MostrarDatosEnGrilla();
            }
            else
            {
                MessageBox.Show($"No se encontró estudiante con el Legajo: {legajo}", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            legajoToolStripMenuItem.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void dNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarDNI frm = new FrmBuscarDNI();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;

            int dni = frm.GetDNI();
            EstudianteDto estudianteDto = _servicioEstudiante.GetEstudiantePorDNI(dni);

            if (estudianteDto != null)
            {
                _lista = new List<EstudianteDto> { estudianteDto }; // solo ese estudiante
                MostrarDatosEnGrilla();
            }
            else
            {
                MessageBox.Show($"No se encontró estudiante con el DNI: {dni}", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dNIToolStripMenuItem.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void toolCertificado_Click(object sender, EventArgs e)
        {
            if (dgvDatosEstudiantes.SelectedRows.Count == 0) return;

            var r = dgvDatosEstudiantes.SelectedRows[0];
            var estudianteDto = (EstudianteDto)r.Tag;
            var carrera= _servicioCarreras.GetCarreraPorId(_carreraId);
            if (estudianteDto.EstadoEstudiante==EstadoEstudiante.Regular.ToString())
            {
                
                ImprimirHelper.CrearCertificadoAlumnoRegular(estudianteDto,carrera.NombreCarrera);
            }

        }

        private void tsVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDatosEstudiantes.SelectedRows.Count == 0) return;

            var r = dgvDatosEstudiantes.SelectedRows[0];
            var estudianteDto = (EstudianteDto)r.Tag;

            FrmInscripcionMaterias frm = new FrmInscripcionMaterias(estudianteDto.EstudianteId);
            frm.ShowDialog();
        }

        private void examenesFinalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDatosEstudiantes.SelectedRows.Count == 0) return;

            var r = dgvDatosEstudiantes.SelectedRows[0];
            var estudianteDto = (EstudianteDto)r.Tag;
            FrmInscripcionExamenes frm = new FrmInscripcionExamenes(estudianteDto.EstudianteId);
            frm.ShowDialog();
        }

        private void materiasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Falta formulario para historial de materias
        }

        private void examenesFinalesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Falta formulario para historial de examenes finales
        }
    }
}
