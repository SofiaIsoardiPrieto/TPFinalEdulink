using EduLink.Datos.Interfaces;
using EduLink.Datos.Repositorios;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using EduLink.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace EduLink.Servicios.Servicios
{
    public class ServiciosHistorialMaterias : IServiciosHistorialMaterias
    {
        private readonly IRepositorioHistorialMaterias _repositorio;
        public ServiciosHistorialMaterias()
        {
            _repositorio = new RepositorioHistorialMaterias();
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

      

        public List<EstudianteHistorialMateriaDto> GetHistorialMateriaPorPagina(int estudianteId, int registrosPorPagina, int paginaActual)
        {
            try
            {
                return _repositorio.GetHistorialMateriaPorPagina(estudianteId, registrosPorPagina, paginaActual);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<EstudianteHistorialMateriaDto> GetHistorialMateriasCompleto(int estudianteId)
        {
            try
            {
                return _repositorio.GetHistorialMateriasCompleto(estudianteId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
