using EduLink.Datos.Interfaces;
using EduLink.Datos.Repositorios;
using EduLink.Entidades.Entidades;
using EduLink.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace EduLink.Servicios.Servicios
{
    public class ServiciosInscripcionExamenes : IServiciosInscripcionExamenes
    {
        private readonly IRepositorioInscripcionExamenes _repositorio;
        public ServiciosInscripcionExamenes()
        {
            _repositorio = new RepositorioInscripcionExamenes();
        }
        /// <summary>
        /// Verifica que no este ya inscrpto el estudiante a un examen
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <param name="examenId"></param>
        /// <returns></returns>
        public bool Existe(int estudianteId, int examenId)
        {
            try
            {
                return _repositorio.Existe( estudianteId, examenId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Obtiene la cantidad de examenes a los que se puede inscrbir el estudiante
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
        /// Pagina los examenes a los que se puede inscribir el estudiante, segun la cantidad de registros por pagina y la pagina actual
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <param name="registrosPorPagina"></param>
        /// <param name="paginaActual"></param>
        /// <returns></returns>

        public List<ExamenDto> GetExamenesInscripcionEstudiantePorPagina(int estudianteId,  int registrosPorPagina, int paginaActual)
        {
            try
            {
                return _repositorio.GetExamenesInscripcionEstudiantePorPagina(estudianteId,  registrosPorPagina, paginaActual);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Guarda la inscrpcion de una estudiante a un examen.
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <param name="examenId"></param>

        public void Guardar(int estudianteId, int examenId)
        {
            try
            {
                _repositorio.Guardar(estudianteId, examenId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //public void Borrar(int examenId)
        //{
        //    try
        //    {
        //        _repositorio.Borrar(examenId);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //public bool EstaRelacionado(int examenId)
        //{
        //    try
        //    {
        //        return _repositorio.EstaRelacionado(examenId);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

       

        



        //public Examen GetExamenPorId(int examenId)
        //{
        //    try
        //    {
        //        return _repositorio.GetExamenPorId(examenId);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //public void Guardar(Examen examen)
        //{

        //    try
        //    {
        //        if (examen.ExamenId == 0)
        //        {
        //            _repositorio.Agregar(examen);
        //        }
        //        else
        //        {
        //            _repositorio.Editar(examen);
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
