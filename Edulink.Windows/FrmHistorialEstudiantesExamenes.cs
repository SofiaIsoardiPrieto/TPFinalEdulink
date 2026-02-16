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
    public partial class FrmHistorialEstudiantesExamenes : Form
    {
        private int _estudianteId;
        private readonly IServiciosHistorialExamenes _servicioHistorialExamenes;
        private readonly IServiciosEstudiantes _servicioEstudiantes;
        private List<EstudianteHistorialExamenDto> _lista;
        private int _paginaActual = 1; // Número de página actual en la paginación. Se inicia en la primera página.
        private int _registrosTotales;
        private int _paginasTotales; // Cantidad total de páginas calculadas en base a los registros disponibles.
        private int _registrosPorPagina = 5; // Cantidad de registros que se mostrarán por página.
        //private bool _filterOn = false; // por lo pronto no lo necesito
        //private Estado? _estadoExamen;

        public FrmHistorialEstudiantesExamenes(int estudianteId)
        {
            InitializeComponent();
            _estudianteId = estudianteId;
            _servicioHistorialExamenes = new ServiciosHistorialExamenes();      
            _servicioEstudiantes = new ServiciosEstudiantes();
        }

        private void FrmMaterias_Load(object sender, EventArgs e)
        {
            if (_servicioHistorialExamenes is null) // comprueba que el servicio se haya inicializado correctamente.
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
                _registrosTotales = _servicioHistorialExamenes.GetCantidad(_estudianteId);// obtiene la cantidad total de registros.
                if (_registrosTotales == 0)
                {
                    MessageBox.Show("El estudiante aun no aprobó examnes", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }
                _paginasTotales = FormHelper.CalcularPaginas(_registrosTotales, _registrosPorPagina);// calcula el total de páginas.
                MostrarPaginado();
            }
            catch (Exception) { throw; }
        }
        private void MostrarPaginado()
        {
            _lista = _servicioHistorialExamenes.GetHistorialExamenesPorPagina(_estudianteId, _registrosPorPagina, _paginaActual);
            lblLegajo.Text = _lista[0].Legajo.ToString();
            lblNombreEstudiante.Text = _lista[0].Apellidos + ", " + _lista[0].Nombres;
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

        private void tsImprimir_Click(object sender, EventArgs e)
        {
            var listaCompleta = _servicioHistorialExamenes.GetHistorialExamenesCompleto(_estudianteId);

            ImprimirHelper.CrearCertificadoExamenesAprobadas(listaCompleta);
            
        }
    }
} 
