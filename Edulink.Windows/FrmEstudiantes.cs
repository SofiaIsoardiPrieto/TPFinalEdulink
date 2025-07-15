using Edulink.Windows.Helpers;
using EduLink.Entidades.Entidades;
using EduLink.Servicios.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Edulink.Windows
{
    public partial class FrmEstudiantes : Form
    {
        private readonly ServiciosEstudiantes _servicio;
        private List<Estudiante> lista;
        int paginaActual = 1;
        int registro;
        int paginas;
        int registrosPorPagina = 5;
        public FrmEstudiantes()
        {
            InitializeComponent();
            _servicio = new ServiciosEstudiantes();
        }

        private void FrmEstudiantes_Load(object sender, EventArgs e)
        {
            if (_servicio is null)
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
                registro = _servicio.GetCantidad();
                paginas = FormHelper.CalcularPaginas(registro, registrosPorPagina);
                MostrarPaginado();
            }
            catch (Exception) { throw; }
        }
        private void MostrarPaginado()
        {
            lista = _servicio.GetEstudiantesPorPagina(registrosPorPagina, paginaActual);
            MostrarDatosEnGrilla();
        }
        private void MostrarDatosEnGrilla()
        {

            GridHelper.LimpiarGrilla(dgvDatosEstudiantes);
            foreach (var estudiante in lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvDatosEstudiantes);
                GridHelper.SetearFila(r, estudiante);
                GridHelper.AgregarFila(dgvDatosEstudiantes, r);
            }
            ActualizarBotonesPaginado();
        }
        private void ActualizarBotonesPaginado()
        {
            if (registro <= registrosPorPagina)
            {
                btnPrimero.Enabled = false;
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
                return;
            }
            if (paginaActual == paginas)
            {
                btnPrimero.Enabled = true;
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
            }
            if (paginaActual < paginas)
            {
                btnPrimero.Enabled = true;
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }
            if (paginaActual > paginas)
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
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            paginaActual++;
            if (paginaActual == paginas)
            {
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;

            }
            lblPaginaActual.Text = (paginaActual).ToString();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            paginaActual = paginas;
            lblPaginaActual.Text = (paginaActual).ToString();
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {

        }

        private void tsEditar_Click(object sender, EventArgs e)
        {

        }

        private void tsBorrar_Click(object sender, EventArgs e)
        {

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

        }
        private void tsVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
