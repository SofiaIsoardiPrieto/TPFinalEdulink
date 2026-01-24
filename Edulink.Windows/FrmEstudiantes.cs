using Edulink.Windows.Helpers;
using EduLink.Entidades.Dtos;
using EduLink.Servicios.Servicios;
using EduLink.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EduLink.Entidades.Entidades;

namespace Edulink.Windows
{
    public partial class FrmEstudiantes : Form
    {
        // Se usa readonly para asegurar que no se reasigne fuera del constructor.
        private readonly IServiciosEstudiantes _servicio;
        private List<EstudianteDto> _lista;
        private int _carreraId;
        private int _paginaActual = 1; // Número de página actual en la paginación. Se inicia en la primera página.
        private int _registrosTotales;
        private int _paginasTotales; // Cantidad total de páginas calculadas en base a los registros disponibles.
        private int _registrosPorPagina = 5; // Cantidad de registros que se mostrarán por página.
        private bool _filterOn = false;
        public FrmEstudiantes(int carreraId)
        {
            InitializeComponent(); // Inicializa los controles del formulario.
            _servicio = new ServiciosEstudiantes(); // Se instancia el servicio concreto.
            // ¿Sería útil usar inyección de dependencias para mayor flexibilidad?
            _carreraId= carreraId;
        }

        private void FrmEstudiantes_Load(object sender, EventArgs e)
        {
            if (_servicio is null) // comprueba que el servicio se haya inicializado correctamente.
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
                _registrosTotales = _servicio.GetCantidad(_carreraId);// obtiene la cantidad total de registros.
                _paginasTotales = FormHelper.CalcularPaginas( _registrosTotales, _registrosPorPagina);// calcula el total de páginas.
                MostrarPaginado();
            }
            catch (Exception) { throw; }
        }
        /// <summary>
        /// Carga y muestra los datos de estudiantes correspondientes a la página actual.
        /// </summary>
        private void MostrarPaginado()
        {
            _lista = _servicio.GetEstudiantesPorPagina(_carreraId, _registrosPorPagina, _paginaActual);
            MostrarDatosEnGrilla();
        }
        /// <summary>
        /// Popula la grilla con los datos de estudiantes.
        /// </summary>
        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatosEstudiantes);
            foreach (var estudiante in _lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvDatosEstudiantes);
                GridHelper.SetearFila(r, estudiante);
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
            //orden = Orden.SinOrden;
            //brand = null;
            //colour = null;
            //rangoPrecio = null;
            //FiltrotoolStripButton.Enabled = true;
            //brandToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            //colourToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            //rangoDePrecioToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            //aZToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            //zAToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            //menorPercioToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            //mayorPrecioToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
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
            if (dgvDatosEstudiantes.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatosEstudiantes.SelectedRows[0];
            EstudianteDto estudianteDto = (EstudianteDto)r.Tag;
            EstudianteDto estudianteDtoCopia = (EstudianteDto)estudianteDto.Clone();
            Estudiante estudiante = _servicio.GetEstudiantePorId(estudianteDto.EstudianteId);
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
                if (!_servicio.EstaRelacionado(estudianteDto.EstudianteId))
                {
                    _servicio.Borrar(estudianteDto.EstudianteId);
                    GridHelper.QuitarFila(dgvDatosEstudiantes, r);
                    _registrosTotales = _servicio.GetCantidad(_carreraId);
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

        private void tsMaterias_Click(object sender, EventArgs e)
        {
            if (dgvDatosEstudiantes.SelectedRows.Count == 0) return;

            var r = dgvDatosEstudiantes.SelectedRows[0];
            var estudiante = (EstudianteDto)r.Tag;

            FrmEstudianteMaterias frm = new FrmEstudianteMaterias(estudiante.EstudianteId);
            frm.ShowDialog(this);
        }

        private void tsFinales_Click(object sender, EventArgs e)
        {
            if (dgvDatosEstudiantes.SelectedRows.Count == 0) return;

            var r = dgvDatosEstudiantes.SelectedRows[0];
            var estudiante = (EstudianteDto)r.Tag;

            FrmEstudianteExamenes frm = new FrmEstudianteExamenes(estudiante.EstudianteId);
            frm.ShowDialog(this);
        }


      

        private void tsActualizar_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void dNIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBuscarDNI frm = new FrmBuscarDNI();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;

            int dni = frm.GetDNI();
            EstudianteDto estudianteDto = _servicio.GetEstudiantePorDNI(dni);

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
        }


        private void legajoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBuscarLegajo frm = new FrmBuscarLegajo();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;

            int legajo = frm.GetLegajo();
            EstudianteDto estudianteDto = _servicio.GetEstudiantePorLegajo(legajo);

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
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void libreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void recibidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void legajoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dNIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void edadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void tsVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
