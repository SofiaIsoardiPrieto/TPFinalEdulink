using Edulink.Windows.Helpers;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using EduLink.Entidades.Enums;
using EduLink.Servicios.Interfaces;
using EduLink.Servicios.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Edulink.Windows
{
    public partial class FrmEstudiantesExamen : Form
    {
        private int _examenId;
        private readonly IServiciosEstudiantesExamen _servicioEstudiantesExamen;
      //  private readonly IServiciosCarreras _servicioCarreras;
        private List<EstudianteExamenDto> _lista;
        private int _paginaActual = 1; // Número de página actual en la paginación. Se inicia en la primera página.
        private int _registrosTotales;
        private int _paginasTotales; // Cantidad total de páginas calculadas en base a los registros disponibles.
        private int _registrosPorPagina = 5; // Cantidad de registros que se mostrarán por página.
        private bool _filterOn = false; // por lo pronto no lo necesito
        private Estado? _estadoExamen;

        public FrmEstudiantesExamen(int examenId)
        {
            InitializeComponent();
            _examenId = examenId;
            _servicioEstudiantesExamen = new ServiciosEstudiantesExamen();      

            //_servicioCarreras = new ServiciosCarreras();
        }

        private void FrmExamenes_Load(object sender, EventArgs e)
        {
            if (_servicioEstudiantesExamen is null) // comprueba que el servicio se haya inicializado correctamente.
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
                _registrosTotales = _servicioEstudiantesExamen.GetCantidad(_examenId);// obtiene la cantidad total de registros.
                _paginasTotales = FormHelper.CalcularPaginas(_registrosTotales, _registrosPorPagina);// calcula el total de páginas.
                MostrarPaginado();
            }
            catch (Exception) { throw; }
        }
        private void MostrarPaginado()
        {
            _lista = _servicioEstudiantesExamen.GetEstudiantesExamenPorPagina(_examenId, _registrosPorPagina, _paginaActual);
            MostrarDatosEnGrilla();
        }
        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatosEstudiantesExamen);
            foreach (var examenDto in _lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvDatosEstudiantesExamen);
                GridHelper.SetearFila(r, examenDto);
                GridHelper.AgregarFila(dgvDatosEstudiantesExamen, r);
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
       


  

        private void tsEditar_Click(object sender, EventArgs e)
        {

            // Podria simplificarse
            if (dgvDatosEstudiantesExamen.SelectedRows.Count == 0) { return; }
            var r = dgvDatosEstudiantesExamen.SelectedRows[0];
            EstudianteExamenDto estudianteExamenDto = (EstudianteExamenDto)r.Tag;
            EstudianteExamenDto estudianteExamenDtoCopia = (EstudianteExamenDto)estudianteExamenDto.Clone();
           
            try
            {
                FrmNotaAE frm = new FrmNotaAE() { Text = "Editar Nota" };
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    GridHelper.SetearFila(r, estudianteExamenDtoCopia);
                    return;
                }
                int? nota = frm.Getnota();

                if (nota != null)
                {
                    estudianteExamenDto.Nota = (int)nota;
                    if (nota==0)
                    {
                        estudianteExamenDto.EstadoExamen = Estado.Ausente;
                        
                    }else if (nota < 4)
                    {
                        estudianteExamenDto.EstadoExamen = Estado.Desaprobado;
                    }
                    else
                    {
                        estudianteExamenDto.EstadoExamen = Estado.Aprobado;
                    }
                    _servicioEstudiantesExamen.Guardar(estudianteExamenDto);
                    GridHelper.SetearFila(r, estudianteExamenDto);
                }
                else
                {
                    GridHelper.SetearFila(r, estudianteExamenDtoCopia);
                }
                RecargarGrilla();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {
                GridHelper.SetearFila(r, estudianteExamenDtoCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
