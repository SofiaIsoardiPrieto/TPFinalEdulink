using Edulink.Windows.Helpers;
using EduLink.Entidades.Entidades;
using EduLink.Entidades.Enums;
using EduLink.Servicios.Interfaces;
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
    public partial class FrmMaterias : Form
    {
       
        private int _carreraId;
        private readonly IServiciosMaterias _servicioMaterias;
        private readonly IServiciosCarreras _servicioCarreras;
        private List<Materia> _lista;
        private int _paginaActual = 1; // Número de página actual en la paginación. Se inicia en la primera página.
        private int _registrosTotales;
        private int _paginasTotales; // Cantidad total de páginas calculadas en base a los registros disponibles.
        private int _registrosPorPagina = 5; // Cantidad de registros que se mostrarán por página.
        private bool _filterOn = false; // por lo pronto no lo necesito
        private Estado? _estadoExamen;

        public FrmMaterias(int carreraId)
        {
            InitializeComponent();
            _carreraId = carreraId;
            _servicioMaterias = new ServiciosMaterias();
            _servicioCarreras = new ServiciosCarreras();
        }

        private void FrmMaterias_Load(object sender, EventArgs e)
        {
            if (_servicioMaterias is null) // comprueba que el servicio se haya inicializado correctamente.
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
                _registrosTotales = _servicioMaterias.GetCantidad(_carreraId);// obtiene la cantidad total de registros.
                _paginasTotales = FormHelper.CalcularPaginas(_registrosTotales, _registrosPorPagina);// calcula el total de páginas.
                MostrarPaginado();
            }
            catch (Exception) { throw; }
        }
        private void MostrarPaginado()
        {
            _lista = _servicioMaterias.GetMateriasPorPagina(_carreraId, _registrosPorPagina, _paginaActual);
            MostrarDatosEnGrilla();
        }
        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatosMaterias);
            foreach (var examenDto in _lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvDatosMaterias);
                GridHelper.SetearFila(r, examenDto);
                GridHelper.AgregarFila(dgvDatosMaterias, r);
            }

            lblPaginaActual.Text = _paginaActual.ToString();
            lblPaginasTotales.Text = _paginasTotales.ToString();
            lblRegistros.Text = _registrosTotales.ToString();
            ActualizarBotonesPaginado();

        }
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


        private void tsNuevo_Click(object sender, EventArgs e)
        {
            //FrmExamenAE frm = new FrmExamenAE(_carreraId);
            //DialogResult dr = frm.ShowDialog(this);
            //RecargarGrilla();
            //MostrarDatosEnGrilla();
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            //if (dgvDatosMaterias.SelectedRows.Count == 0) { return; }
            //var r = dgvDatosMaterias.SelectedRows[0];
            //ExamenDto examenDto = (ExamenDto)r.Tag;
            //ExamenDto examenDtoCopia = (ExamenDto)examenDto.Clone();
            //Examen examen = _servicioMaterias.GetMateriaPorId(examenDto.ExamenId);
            //try
            //{
            //    FrmExamenAE frm = new FrmExamenAE(_carreraId) { Text = "Editar Exámen" };
            //    frm.SetExamen(examen);
            //    DialogResult dr = frm.ShowDialog(this);
            //    if (dr == DialogResult.Cancel)
            //    {
            //        GridHelper.SetearFila(r, examenDtoCopia);
            //        return;
            //    }
            //    examen = frm.GetExamen();
            //    if (examenDto != null)
            //    {
            //        GridHelper.SetearFila(r, examenDto);
            //    }
            //    else
            //    {
            //        GridHelper.SetearFila(r, examenDtoCopia);
            //    }
            //    RecargarGrilla();
            //    MostrarDatosEnGrilla();
            //}
            //catch (Exception ex)
            //{
            //    GridHelper.SetearFila(r, examenDtoCopia);
            //    MessageBox.Show(ex.Message, "Error",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void tsBorrar_Click(object sender, EventArgs e)
        {
            //if (dgvDatosMaterias.SelectedRows.Count == 0) return;
            //var r = dgvDatosMaterias.SelectedRows[0];
            //ExamenDto examenDto = (ExamenDto)r.Tag;
            //try
            //{
            //    DialogResult dr = MessageBox.Show("¿Desea dar de baja el registro seleccionado?", // Se le pone como alumno libre
            //        "Confirmar",
            //        MessageBoxButtons.YesNo,
            //        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //    if (dr == DialogResult.No) { return; }
            //    if (!_servicioMaterias.EstaRelacionado(examenDto.ExamenId))// Veo si el estudiante esta en otras tablas, problema de FK
            //    {
            //        _servicioMaterias.Borrar(examenDto.ExamenId);
            //        GridHelper.QuitarFila(dgvDatosMaterias, r);
            //        _registrosTotales = _servicioMaterias.GetCantidad(_carreraId);
            //        _paginasTotales = FormHelper.CalcularPaginas(_registrosTotales, _registrosPorPagina);
            //        lblRegistros.Text = _registrosTotales.ToString();
            //        lblPaginasTotales.Text = _paginasTotales.ToString();
            //        MessageBox.Show("Ezmane eliminado exitosamente", "Mensaje", // Esto como afecta finales o cursadas?
            //            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        RecargarGrilla();
            //        MostrarDatosEnGrilla();
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message, "Mensaje",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void tsAlumnos_Click(object sender, EventArgs e)
        {
            if (dgvDatosMaterias.SelectedRows.Count == 0) return;
            var r = dgvDatosMaterias.SelectedRows[0];
            Materia materia = (Materia)r.Tag;
            FrmEstudiantesMateria frm = new FrmEstudiantesMateria(materia.MateriaId);
            frm.ShowDialog(this);
        }

        private void tsActualizar_Click(object sender, EventArgs e)
        {
            LimpiarBotonesYActualizarLista();
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
        private void tsVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
