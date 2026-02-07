using EduLink.Datos.Interfaces;
using EduLink.Datos.Repositorios;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using EduLink.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace EduLink.Servicios.Servicios
{
    public class ServiciosEstudiantesExamen : IServiciosEstudiantesExamen
    {
        private readonly IRepositorioEstudiantesExamen _repositorio;
        public ServiciosEstudiantesExamen()
        {
            _repositorio = new RepositorioEstudiantesExamen();
        }

        public int GetCantidad(int examenId)
        {
            try
            {
                return _repositorio.GetCantidad(examenId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<EstudianteExamenDto> GetEstudiantesExamenPorPagina(int examenId, int registrosPorPagina, int paginaActual)
        {
            try
            {
                return _repositorio.GetEstudiantesExamenPorPagina(examenId, registrosPorPagina, paginaActual);
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

        //public bool Existe(Examen examen)
        //{
        //    try
        //    {
        //        return _repositorio.Existe(examen);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}

        //public int GetCantidad(int carreraId)
        //{
        //    try
        //    {
        //        return _repositorio.GetCantidad(carreraId);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //public int GetCantidad(int carreraId, int anioMateria)
        //{
        //    try
        //    {
        //        return GetCantidad(carreraId, anioMateria);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //public List<ExamenDto> GetExamenesPorPagina(int carreraId, int registrosPorPagina, int paginaActual)
        //{
        //    try
        //    {
        //        return _repositorio.GetExamenesPorPagina(carreraId, registrosPorPagina, paginaActual);
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

       

        public void Guardar(EstudianteExamenDto estudianteExamenDto)
        {
            try
            {
                _repositorio.Editar(estudianteExamenDto);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
