using EduLink.Datos.Interfaces;
using EduLink.Datos.Repositorios;
using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using EduLink.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace EduLink.Servicios.Servicios
{
    public class ServiciosEstudiantesMaterias : IServiciosEstudiantesMaterias
    {
        private readonly IRepositorioEstudiantesMaterias _repositorio;
        public ServiciosEstudiantesMaterias()
        {
            _repositorio = new RepositorioEstudiantesMaterias();
        }
        /// <summary>
        /// Trae la cantidad de materias disponibles (filtra por correlativas) de un estudiante
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
        /// Trae las materias disponibles (filtra por correlativas) de un estudiante por pagina
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <param name="registrosPorPagina"></param>
        /// <param name="paginaActual"></param>
        /// <returns></returns>

        public List<MateriaDto> GetMateriasPorEstudiantePorPagina(int estudianteId, int registrosPorPagina, int paginaActual)
        {
            try
            {
                return _repositorio.GetEstudiantesPorPagina(estudianteId, registrosPorPagina,paginaActual);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
