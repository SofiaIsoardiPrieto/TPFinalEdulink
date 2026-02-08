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
    public partial class FrmInscripcionExamenes : Form
    {
        private int _estudianteId;
        private List<ExamenDto> _lista;
        private IServiciosInscripcionExamenes _servicioInscripcionExamenes;
       
        private bool _inscripto;
        //  private int _carreraId;
        private int _paginaActual = 1; // Número de página actual en la paginación. Se inicia en la primera página.
        private int _registrosTotales;
        private int _paginasTotales; // Cantidad total de páginas calculadas en base a los registros disponibles.
        private int _registrosPorPagina = 5; // Cantidad de registros que se mostrarán por página.
        public FrmInscripcionExamenes(int estudianteId)
        {
            InitializeComponent();
            _servicioInscripcionExamenes = new ServiciosInscripcionExamenes();
            _estudianteId = estudianteId;

        }
        private void FrmInscripcionExamenes_Load(object sender, EventArgs e)
        {
            if (_servicioInscripcionExamenes is null) // comprueba que el servicio se haya inicializado correctamente.
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
                _registrosTotales = _servicioInscripcionExamenes.GetCantidad(_estudianteId);// obtiene la cantidad total de registros.
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
            _lista = _servicioInscripcionExamenes.GetExamenesInscripcionEstudiantePorPagina(_estudianteId, _registrosPorPagina, _paginaActual);
            MostrarDatosEnGrilla();
        }
        /// <summary>
        /// Popula la grilla con los datos de estudiantes.
        /// </summary>
        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvInscripcionExamenes);
            foreach (var materiaDto in _lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(dgvInscripcionExamenes);
                GridHelper.SetearFila(r, materiaDto);

                // Cambia color si la materia ya está inscripta
                if (_inscripto) // o la condición que uses para saber si está inscripta
                {
                    r.DefaultCellStyle.BackColor = Color.FromArgb(230, 230, 250);
                }
                else
                {
                    r.DefaultCellStyle.BackColor = Color.FromArgb(249, 245, 253);
                }

                GridHelper.AgregarFila(dgvInscripcionExamenes, r);
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
                   
            RecargarGrilla();
        }

        private void tsVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsInscribir_Click(object sender, EventArgs e)
        {
            if (dgvInscripcionExamenes.SelectedRows.Count == 0) { return; }
            DataGridViewRow r = dgvInscripcionExamenes.SelectedRows[0];
            ExamenDto examenDto = (ExamenDto)r.Tag;

            try
            {
                if (!_servicioInscripcionExamenes.Existe(_estudianteId, examenDto.ExamenId))// si ya esta inscripto, no lo inscribe de nuevo, sino que muestra un mensaje de error.
                {
                    _servicioInscripcionExamenes.Guardar(_estudianteId, examenDto.ExamenId);


                    MessageBox.Show("Inscripción realizada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarGrilla();
                }
                else
                {
                    MessageBox.Show("No se puedo realizar la inscripción", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

      
        // Usar el editar, y que checke que existe la inscrpcion con el Existe(), sino existe cartel
        //de error que diga que no se puede editar una inscripcion que no existe. Que primero lo inscriba y luego se podra editar.
        private void tsEditar_Click(object sender, EventArgs e)
        {
            //if (dgvInscripcionMaterias.SelectedRows.Count == 0) { return; }
            //var r = dgvInscripcionMaterias.SelectedRows[0];
            //EstudianteDto estudianteDto = (EstudianteDto)r.Tag;
            //EstudianteDto estudianteDtoCopia = (EstudianteDto)estudianteDto.Clone();
            //Estudiante estudiante = _servicioEstudiante.GetEstudiantePorId(estudianteDto.EstudianteId);
            //try
            //{
            //    FrmEstudianteAE frm = new FrmEstudianteAE(_carreraId) { Text = "Editar Estudiante" };
            //    frm.SetEstudiante(estudiante);
            //    DialogResult dr = frm.ShowDialog(this);
            //    if (dr == DialogResult.Cancel)
            //    {
            //        GridHelper.SetearFila(r, estudianteDtoCopia);
            //        return;
            //    }
            //    estudiante = frm.GetEstudiante();
            //    if (estudianteDto != null)
            //    {
            //        GridHelper.SetearFila(r, estudianteDto);
            //    }
            //    else
            //    {
            //        GridHelper.SetearFila(r, estudianteDtoCopia);
            //    }
            //    RecargarGrilla();
            //    MostrarDatosEnGrilla();
            //}
            //catch (Exception ex)
            //{
            //    GridHelper.SetearFila(r, estudianteDtoCopia);
            //    MessageBox.Show(ex.Message, "Error",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void tsBorrar_Click(object sender, EventArgs e)
        {
            //if (dgvInscripcionExamenes.SelectedRows.Count == 0) return;
            //var r = dgvInscripcionExamenes.SelectedRows[0];
            //MateriaDto materiaDto = (MateriaDto)r.Tag;
            //try
            //{
            //    DialogResult dr = MessageBox.Show("¿Desea dar de baja el registro seleccionado?",
            //        "Confirmar",
            //        MessageBoxButtons.YesNo,
            //        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //    if (dr == DialogResult.No) { return; }

            //    if (!_servicioEstudianteExamenes.Existe(_estudianteId, materiaDto.MateriaId))
            //    {
            //        //   _servicioEstudianteExamenes.Borrar(_estudianteId, materiaDto.MateriaId );

            //        MessageBox.Show($"Se eliminó la inscripcion a la materia {materiaDto.NombreMateria}", "Confirmación",
            //            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        MostrarDatosEnGrilla();
            //    }
            //    else
            //    {
            //        MessageBox.Show($"No se encontró registro del estudiante en la materia: {materiaDto.NombreMateria}", "Error",
            //            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        MostrarDatosEnGrilla();
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message, "Mensaje",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

    

        //todo  : imprimir certificado de inscripcion de finales
        private void tsCertificado_Click(object sender, EventArgs e)
        {

            //  ImprimirHelper.CertificadoIncripcionExameness(_estudianteId);
        }

        private void tsActualizar_Click(object sender, EventArgs e)
        {
            LimpiarBotonesYActualizarLista();
        }

     
    }
}
