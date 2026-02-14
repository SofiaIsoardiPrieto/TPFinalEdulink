using EduLink.Datos.Interfaces;
using EduLink.Datos.Repositorios;
using EduLink.Entidades.Entidades;
using EduLink.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace EduLink.Servicios.Servicios
{
    public class ServiciosMaterias : IServiciosMaterias
    {
        private readonly IRepositorioMaterias _repositorio;
        public ServiciosMaterias()
        {
            _repositorio = new RepositorioMaterias();
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

        //public int GetCantidad(int carreraId, int anioMateria)
        //{
        //    try
        //    {
        //        return GetCantidad( carreraId,  anioMateria);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        public List<Materia> GetMateriasPorPagina(int carreraId, int registrosPorPagina, int paginaActual)
        {
            try
            {
                return _repositorio.GetMateriasPorPagina(carreraId, registrosPorPagina, paginaActual);
            }
            catch (Exception)
            {

                throw;
            }
        }

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
