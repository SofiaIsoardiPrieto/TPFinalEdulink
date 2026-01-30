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

        public bool Existe(int estudianteId, int materiaId)
        {
            try
            {
                return _repositorio.Existe(estudianteId, materiaId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Guardar(int estudianteId, int materiaId)
        {
            try
            {
                if (estudianteId == 0 || materiaId==0)
                {
                    _repositorio.Agregar(estudianteId,materiaId);
                }
                else
                {
                    _repositorio.Editar(estudianteId,materiaId);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Trae la cantidad de materias disponibles (filtra por correlativas) de un estudiante
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <returns></returns>
        public int GetCantidad(int estudianteId, int anioMateria, bool inscripto)
        {
            try
            {
                return _repositorio.GetCantidad(estudianteId, anioMateria,  inscripto);
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

        public List<MateriaDto> GetMateriasPorEstudiantePorPagina(int estudianteId, int anioMateria, bool inscripto, int registrosPorPagina, int paginaActual)
        {
            try
            {
                return _repositorio.GetEstudiantesPorPagina(estudianteId,  anioMateria,  inscripto,registrosPorPagina, paginaActual);
            }
            catch (Exception)
            {

                throw;
            }
        }

       
    }
}
