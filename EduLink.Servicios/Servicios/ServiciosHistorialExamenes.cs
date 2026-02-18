using EduLink.Datos.Interfaces;
using EduLink.Datos.Repositorios;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using EduLink.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace EduLink.Servicios.Servicios
{
    public class ServiciosHistorialExamenes : IServiciosHistorialExamenes
    {
        private readonly IRepositorioHistorialExamenes _repositorio;
        public ServiciosHistorialExamenes()
        {
            _repositorio = new RepositorioHistorialExamenes();
        }


        /// <summary>
        /// Obtener la cantidad de examenes aprobados por un estudiante
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

         }
        /// <summary>
        /// Paginas los examenes aprobados por un estudiante.
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <param name="registrosPorPagina"></param>
        /// <param name="paginaActual"></param>
        /// <returns></returns>

        public List<EstudianteHistorialExamenDto> GetHistorialExamenesPorPagina(int estudianteId, int registrosPorPagina, int paginaActual)
        {
            try
            {
                return _repositorio.GetHistorialExamenesPorPagina(estudianteId, registrosPorPagina, paginaActual);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Obtener la lista completa (sin paginar) de examenes aprobados por un estudiante, para exportar a pdf.
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <returns></returns>
        public List<EstudianteHistorialExamenDto> GetHistorialExamenesCompleto(int estudianteId)
        {
            try
            {
                return _repositorio.GetHistorialExamenesCompleto(estudianteId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
