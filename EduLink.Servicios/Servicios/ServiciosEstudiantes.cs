using EduLink.Datos.Interfaces;
using EduLink.Datos.Repositorios;
using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using EduLink.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;

namespace EduLink.Servicios.Servicios
{
    public class ServiciosEstudiantes : IServiciosEstudiantes
    {
        private readonly IRepositorioEstudiantes _repositorio;
        public ServiciosEstudiantes()
        {
            _repositorio = new RepositorioEstudiantes();
        }
        /// <summary>
        /// Determina si ya existe un estudiante 
        /// </summary>
        /// <param name="estudiante"></param>
        /// <returns></returns>
        public bool Existe(Estudiante estudiante)
        {
            try
            {
                return _repositorio.Existe(estudiante);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Agrega o edita un estudiante
        /// </summary>
        /// <param name="estudiante"></param>

        public void Guardar(Estudiante estudiante)
        {
            try
            {
                if (estudiante.EstudianteId == 0)
                {
                    _repositorio.Agregar(estudiante);
                }
                else
                {
                    _repositorio.Editar(estudiante);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Determina si un estudiante esta relacionado con alguna otra entidad
        /// </summary>NuevoId;
        /// <param name="estudianteId"></param>
        /// <returns></returns>
        public bool EstaRelacionado(int estudianteId)
        {
            return _repositorio.EstaRelacionado(estudianteId);
        }
        /// <summary>
        /// Borra un estudiante
        /// </summary>
        /// <param name="estudianteId"></param>
        public void Borrar(int estudianteId)
        {
            try
            {
                _repositorio.Borrar(estudianteId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// obtiene la cantidad de estudiantes
        /// </summary>
        /// <param name="textoFiltro"></param>
        /// <returns></returns>
        public int GetCantidad(int carreraId, string textoFiltro = null)
        {
            try
            {
                return _repositorio.GetCantidad(carreraId,textoFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Devuelve una lista de estudiantesDtos por pagina
        /// </summary>
        /// <param name="registrosPorPagina"></param>
        /// <param name="paginaActual"></param>
        /// <param name="textoFiltro"></param>
        /// <returns></returns>
        public List<EstudianteDto> GetEstudiantesPorPagina(int carreraId, int registrosPorPagina, int paginaActual, string textoFiltro = null)
        {
            try
            {
                return _repositorio.GetEstudiantesPorPagina(carreraId, registrosPorPagina, paginaActual, textoFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Devuelve una lista de estudiantes para cargar en un combo
        /// </summary>
        /// <returns></returns>
        public List<EstudianteCombo> GetEstudiantesCombo()
        {
            try
            {
                return _repositorio.GetEstudiantesCombo();
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Trae un estudiante por su Id
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <returns></returns>
        public Estudiante GetEstudiantePorId(int estudianteId)
        {
            try
            {
                return _repositorio.GetEstudiantePorId(estudianteId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Busca un estudiante por su DNI
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public EstudianteDto GetEstudiantePorDNI(int dni)
        {
            try
            {
                return _repositorio.GetEstudiantePorDNI(dni);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public EstudianteDto GetEstudiantePorLegajo(int legajo)
        {
            try
            {
                return _repositorio.GetEstudiantePorLegajo(legajo);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
