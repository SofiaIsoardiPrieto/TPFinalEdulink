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
    public partial class FrmHistorialEstudiantesMateria : Form
    {
        private int _materiaId;
        private readonly IServiciosEstudiantesMateria _servicioEstudiantesMateria;
        //  private readonly IServiciosCarreras _servicioCarreras;
        private List<EstudianteMateriaDto> _lista;
        private int _paginaActual = 1; // Número de página actual en la paginación. Se inicia en la primera página.
        private int _registrosTotales;
        private int _paginasTotales; // Cantidad total de páginas calculadas en base a los registros disponibles.
        private int _registrosPorPagina = 5; // Cantidad de registros que se mostrarán por página.
        //private bool _filterOn = false; // por lo pronto no lo necesito
        //private Estado? _estadoExamen;

        public FrmEstudiantesMateria(int materiaId)
        {
            InitializeComponent();
            _materiaId = materiaId;
            _servicioEstudiantesMateria = new ServiciosEstudiantesMateria();      

            //_servicioCarreras = new ServiciosCarreras();
        }

        private void FrmMaterias_Load(object sender, EventArgs e)
        {
            if (_servicioEstudiantesMateria is null) // comprueba que el servicio se haya inicializado correctamente.
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
                _registrosTotales = _servicioEstudiantesMateria.GetCantidad(_materiaId);// obtiene la cantidad total de registros.
                _paginasTotales = FormHelper.CalcularPaginas(_registrosTotales, _registrosPorPagina);// calcula el total de páginas.
                MostrarPaginado();
            }
            catch (Exception) { throw; }
        }
        private void MostrarPaginado()
        {
            _lista = _servicioEstudiantesMateria.GetEstudiantesMateriaPorPagina(_materiaId, _registrosPorPagina, _paginaActual);
            MostrarDatosEnGrilla();
        }
        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatosHistorialEstudiantesMateria);
            foreach (var estudianreExamenDto in _lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvDatosHistorialEstudiantesMateria);
                GridHelper.SetearFila(r, estudianreExamenDto);
                GridHelper.AgregarFila(dgvDatosHistorialEstudiantesMateria, r);
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
            if (dgvDatosHistorialEstudiantesMateria.SelectedRows.Count == 0) { return; }
            var r = dgvDatosHistorialEstudiantesMateria.SelectedRows[0];
            EstudianteMateriaDto estudianteMateriaDto = (EstudianteMateriaDto)r.Tag;
            EstudianteMateriaDto estudianteMateriaDtoCopia = (EstudianteMateriaDto)estudianteMateriaDto.Clone();
           
            try
            {
                FrmNotaAE frm = new FrmNotaAE() { Text = "Editar Nota" };
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    GridHelper.SetearFila(r, estudianteMateriaDtoCopia);
                    return;
                }
                int? nota = frm.Getnota();

                if (nota != null)
                {
                    estudianteMateriaDto.Nota = (int)nota;
                    if (nota==0)
                    {
                        estudianteMateriaDto.EstadoMateria = Estado.Ausente;
                        
                    }else if (nota < 4)
                    {
                        estudianteMateriaDto.EstadoMateria = Estado.Desaprobado;
                    }
                    else
                    {
                        estudianteMateriaDto.EstadoMateria = Estado.Aprobado;
                    }
                    _servicioEstudiantesMateria.Guardar(estudianteMateriaDto);
                    GridHelper.SetearFila(r, estudianteMateriaDto);
                }
                else
                {
                    GridHelper.SetearFila(r, estudianteMateriaDtoCopia);
                }
                RecargarGrilla();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {
                GridHelper.SetearFila(r, estudianteMateriaDtoCopia);
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
