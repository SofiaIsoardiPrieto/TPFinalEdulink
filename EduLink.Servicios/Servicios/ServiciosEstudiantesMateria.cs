using EduLink.Datos.Interfaces;
using EduLink.Datos.Repositorios;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using EduLink.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace EduLink.Servicios.Servicios
{
    public class ServiciosEstudiantesMateria : IServiciosEstudiantesMateria
    {
        private readonly IRepositorioEstudiantesMateria _repositorio;
        public ServiciosEstudiantesMateria()
        {
            _repositorio = new RepositorioEstudiantesMateria();
        }

        public int GetCantidad(int materiaId)
        {
            try
            {
                return _repositorio.GetCantidad(materiaId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        

        public List<EstudianteMateriaDto> GetEstudiantesMateriaPorPagina(int materiaId, int registrosPorPagina, int paginaActual)
        {
            try
            {
                return _repositorio.GetEstudiantesMateriaPorPagina(materiaId, registrosPorPagina, paginaActual);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(EstudianteMateriaDto estudianteMateriaDto)
        {
            try
            {
                _repositorio.Editar(estudianteMateriaDto);
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




    }
}
