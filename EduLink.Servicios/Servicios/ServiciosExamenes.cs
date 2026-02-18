using EduLink.Datos.Interfaces;
using EduLink.Datos.Repositorios;
using EduLink.Entidades.Entidades;
using EduLink.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace EduLink.Servicios.Servicios
{
    public class ServiciosExamenes : IServiciosExamenes
    {
        private readonly IRepositorioExamenes _repositorio;
        public ServiciosExamenes()
        {
            _repositorio = new RepositorioExamenes();
        }
        /// <summary>
        /// Borra un examen en la bdd por su ID.
        /// </summary>
        /// <param name="examenId"></param>
        public void Borrar(int examenId)
        {
            try
            {
                _repositorio.Borrar(examenId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Verifica si el examen esta relacionado con otras entidades, 
        /// como por ejemplo si hay estudiantes inscriptos a ese examen
        /// y asi evitar borrarlo.
        /// </summary>
        /// <param name="examenId"></param>
        /// <returns></returns>
        public bool EstaRelacionado(int examenId)
        {
            try
            {
                return _repositorio.EstaRelacionado(examenId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Verifica si ya existe un examen para la misma materia en la misma fecha, evitando así duplicados.
        /// </summary>
        /// <param name="examen"></param>
        /// <returns></returns>
        public bool Existe(Examen examen)
        {
            try
            {
                return _repositorio.Existe(examen);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        /// <summary>
        /// Obtener la cantidad de examenes de ese año de una  carrera
        /// </summary>
        /// <param name="carreraId"></param>
        /// <returns></returns>

        public int GetCantidad(int carreraId)
        {
            try
            {
                return _repositorio.GetCantidad(carreraId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Obtiene la cantidad de examenes de ese año de una carrera
        /// </summary>
        /// <param name="carreraId"></param>
        /// <param name="anioMateria"></param>
        /// <returns></returns>
        public int GetCantidad(int carreraId, int anioMateria)
        {
            try
            {
                return GetCantidad( carreraId,  anioMateria);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Paginar los examenes de una carrera.
        /// </summary>
        /// <param name="carreraId"></param>
        /// <param name="cantidadPorPagina"></param>
        /// <param name="paginaActual"></param>
        /// <returns></returns>

        public List<ExamenDto> GetExamenesPorPagina(int carreraId, int registrosPorPagina, int paginaActual)
        {
            try
            {
                return _repositorio.GetExamenesPorPagina(carreraId, registrosPorPagina, paginaActual);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Obtiene un examen por su Id.
        /// </summary>
        /// <param name="examenId"></param>
        /// <returns></returns>
        public Examen GetExamenPorId(int examenId)
        {
            try
            {
                return _repositorio.GetExamenPorId(examenId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Guarda o edita un examen
        /// </summary>
        /// <param name="examen"></param>
        public void Guardar(Examen examen)
        {

            try
            {
                if (examen.ExamenId == 0)
                {
                    _repositorio.Agregar(examen);
                }
                else
                {
                    _repositorio.Editar(examen);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
