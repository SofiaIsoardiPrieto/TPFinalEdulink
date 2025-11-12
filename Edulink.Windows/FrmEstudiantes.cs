using Edulink.Windows.Helpers;
using EduLink.Entidades.Dtos;
using EduLink.Servicios.Servicios;
using EduLink.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Edulink.Windows
{
    public partial class FrmEstudiantes : Form
    {
        // Interfaz que define los métodos disponibles para trabajar con estudiantes.
        // Se usa readonly para asegurar que no se reasigne fuera del constructor.
        private readonly IServiciosEstudiantes _servicio;
        private List<EstudianteDto> lista;     
        int paginaActual = 1; // Número de página actual en la paginación. Se inicia en la primera página.
        int registrosTotales;
        int paginasTotales;// Cantidad total de páginas calculadas en base a los registros disponibles.
        int registrosPorPagina = 5;   // Cantidad de registros que se mostrarán por página.

        public FrmEstudiantes()
        {
            InitializeComponent(); // Inicializa los controles del formulario.
            _servicio = new ServiciosEstudiantes(); // Se instancia el servicio concreto.
            // ¿Sería útil usar inyección de dependencias para mayor flexibilidad?
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
                registrosTotales = _servicio.GetCantidad();// obtiene la cantidad total de registros.
                paginasTotales = FormHelper.CalcularPaginas(registrosTotales, registrosPorPagina);// calcula el total de páginas.
                MostrarPaginado();
            }
            catch (Exception) { throw; }
        }
        /// <summary>
        /// carga y muestra los datos de estudiantes correspondientes a la página actual.
        /// </summary>
        private void MostrarPaginado()
        {
            lista = _servicio.GetEstudiantesPorPagina(registrosPorPagina, paginaActual);
            MostrarDatosEnGrilla();
        }
        /// <summary>
        /// popula la grilla con los datos de estudiantes.
        /// </summary>
        private void MostrarDatosEnGrilla()
        {

            GridHelper.LimpiarGrilla(dgvDatosEstudiantes);
            foreach (var estudiante in lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvDatosEstudiantes);
                GridHelper.SetearFila(r, estudiante);
                GridHelper.AgregarFila(dgvDatosEstudiantes, r);
            }

            lblPaginaActual.Text = paginaActual.ToString();
            lblPaginasTotales.Text = paginasTotales.ToString();
            lblRegistros.Text = registrosTotales.ToString();
            ActualizarBotonesPaginado();

        }
        /// <summary>
        /// actualiza el estado (habilitado/deshabilitado) de los botones de paginación
        /// </summary>
        private void ActualizarBotonesPaginado()
        {
            if (registrosTotales <= registrosPorPagina)
            {
                btnPrimero.Enabled = false;
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
                return;
            }
            if (paginaActual == paginasTotales)
            {
                btnPrimero.Enabled = true;
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
            }
            if (paginaActual < paginasTotales)
            {
                btnPrimero.Enabled = true;
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }
            if (paginaActual > paginasTotales)
            {
                btnPrimero.Enabled = true;
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }
            if (paginaActual == 1)
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
            paginaActual = 1;
            lblPaginaActual.Text = (paginaActual).ToString();
            MostrarPaginado();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            paginaActual--;
            if (paginaActual == 1)
            {
                btnAnterior.Enabled = false;
                btnPrimero.Enabled = false;
            }
            lblPaginaActual.Text = (paginaActual).ToString();
            MostrarPaginado();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            paginaActual++;
            if (paginaActual == paginasTotales)
            {
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;

            }
            lblPaginaActual.Text = (paginaActual).ToString();
            MostrarPaginado();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            paginaActual = paginasTotales;
            lblPaginaActual.Text = (paginaActual).ToString();
            MostrarPaginado();
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            FrmEstudianteAE frm = new FrmEstudianteAE();
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
            try
            {
                FrmEstudianteAE frm = new FrmEstudianteAE() { Text = "Editar Estudiante" };
                frm.SetExamen(estudianteDto);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    GridHelper.SetearFila(r, estudianteDtoCopia);
                    return;
                }
                estudianteDto = frm.GetExamen();
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
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                if (!_servicio.EstaRelacionado(estudianteDto.EstudianteId))
                {
                    _servicio.Borrar(estudianteDto.EstudianteId);
                    GridHelper.QuitarFila(dgvDatosEstudiantes, r);
                    registrosTotales = _servicio.GetCantidad();
                    paginasTotales = FormHelper.CalcularPaginas(registrosTotales, registrosPorPagina);
                    lblRegistros.Text = registrosTotales.ToString();
                    lblPaginasTotales.Text = paginasTotales.ToString();
                    MessageBox.Show("Prueba borrada exitosamente", "Mensaje",
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

        }

        private void tsFinales_Click(object sender, EventArgs e)
        {

        }

        private void tsFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {

        }

        private void tsActualizar_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }
        private void tsVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
