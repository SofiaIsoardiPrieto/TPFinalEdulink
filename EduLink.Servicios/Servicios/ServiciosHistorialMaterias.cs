using EduLink.Datos.Interfaces;
using EduLink.Datos.Repositorios;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using EduLink.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace EduLink.Servicios.Servicios
{
    public class ServiciosHistorialMaterias : IServiciosHistorialMaterias
    {
        private readonly IRepositorioHistorialMaterias _repositorio;
        public ServiciosHistorialMaterias()
        {
            _repositorio = new RepositorioHistorialMaterias();
        }

        /// <summary>
        /// Obtiene la cantidad de materias aprobadas por un estudiante.
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <returns></returns>

        public int GetCantidad(int estudianteId)
        {
            try
            {
                return _repositorio.GetCantidad(estudianteId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Pagina las materia aprobadas por un estudiante.
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <param name="registrosPorPagina"></param>
        /// <param name="paginaActual"></param>
        /// <returns></returns>


        public List<EstudianteHistorialMateriaDto> GetHistorialMateriaPorPagina(int estudianteId, int registrosPorPagina, int paginaActual)
        {
            try
            {
                return _repositorio.GetHistorialMateriaPorPagina(estudianteId, registrosPorPagina, paginaActual);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Trea la lista completa de materias aprobadas por un estudiante, sin paginar. Se utiliza para exportar a pdf.
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <returns></returns>
        public List<EstudianteHistorialMateriaDto> GetHistorialMateriasCompleto(int estudianteId)
        {
            try
            {
                return _repositorio.GetHistorialMateriasCompleto(estudianteId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
