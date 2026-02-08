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
