using Edulink.Windows.Helpers;
using EduLink.Entidades.Entidades;
using EduLink.Servicios.Interfaces;
using EduLink.Servicios.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Edulink.Windows
{
    public partial class FrmInscripcionMaterias : Form
    {
        private int _estudianteId;
        private List<MateriaDto> _lista;
        private IServiciosEstudiantesMaterias _servicio;
        //  private int _carreraId;
        private int _paginaActual = 1; // Número de página actual en la paginación. Se inicia en la primera página.
        private int _registrosTotales;
        private int _paginasTotales; // Cantidad total de páginas calculadas en base a los registros disponibles.
        private int _registrosPorPagina = 5; // Cantidad de registros que se mostrarán por página.
        public FrmInscripcionMaterias(int estudianteId)
        {
            InitializeComponent();
            _servicio = new ServiciosEstudiantesMaterias();
            _estudianteId = estudianteId;

        }

        private void FrmEstudianteMaterias_Load(object sender, EventArgs e)
        {
            if (_servicio is null) // comprueba que el servicio se haya inicializado correctamente.
            {
                MessageBox.Show("Habilitar el servicio de SQL", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                _registrosTotales = _servicio.GetCantidad(_estudianteId);// obtiene la cantidad total de registros.
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
            _lista = _servicio.GetMateriasPorEstudiantePorPagina(_estudianteId, _registrosPorPagina, _paginaActual);
            MostrarDatosEnGrilla();
        }
        /// <summary>
        /// Popula la grilla con los datos de estudiantes.
        /// </summary>
        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvMateriasEstudiantes);
            foreach (var materiaDto in _lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvMateriasEstudiantes);
                GridHelper.SetearFila(r, materiaDto);
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
        private void LimpiarBotonesYActualizarLista()
        {
            //_filterOn = false;
            //_estadoEstudiante = null;
            //_edadMin = null;
            //_edadMax = null;
            //_anioAlta = null;
            //_ciudadId = null;

            //edadToolStripMenuItem.BackColor = Color.FromArgb(249, 245, 253); // color base
            //regularToolStripMenuItem.BackColor = Color.FromArgb(249, 245, 253); // color base
            //libreToolStripMenuItem.BackColor = Color.FromArgb(249, 245, 253); // color base
            //recibidoToolStripMenuItem.BackColor = Color.FromArgb(249, 245, 253); // color base
            //CiudadToolStripMenuItem.BackColor = Color.FromArgb(249, 245, 253); // color base
            //dNIToolStripMenuItem.BackColor = Color.FromArgb(249, 245, 253); // color base
            //legajoToolStripMenuItem.BackColor = Color.FromArgb(249, 245, 253); // color base
            //FechaIngresoToolStripMenuItem.BackColor = Color.FromArgb(249, 245, 253); // color base

            RecargarGrilla();
        }
    }
}
