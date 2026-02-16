using EduLink.Datos.Interfaces;
using EduLink.Datos.Repositorios;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using EduLink.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace EduLink.Servicios.Servicios
{
    public class ServiciosHistorialExamenes : IServiciosHistorialExamenes
    {
        private readonly IRepositorioHistorialExamenes _repositorio;
        public ServiciosHistorialExamenes()
        {
            _repositorio = new RepositorioHistorialExamenes();
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

      

        public List<EstudianteHistorialExamenDto> GetHistorialExamenesPorPagina(int estudianteId, int registrosPorPagina, int paginaActual)
        {
            try
            {
                return _repositorio.GetHistorialExamenesPorPagina(estudianteId, registrosPorPagina, paginaActual);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<EstudianteHistorialExamenDto> GetHistorialExamenesCompleto(int estudianteId)
        {
            try
            {
                return _repositorio.GetHistorialExamenesCompleto(estudianteId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
