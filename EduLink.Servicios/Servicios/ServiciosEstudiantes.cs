using EduLink.Datos.Interfaces;
using EduLink.Datos.Repositorios;
using EduLink.Entidades.Combos;
using EduLink.Entidades.Entidades;
using EduLink.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace EduLink.Servicios.Servicios
{
    public class ServiciosEstudiantes : IServiciosEstudiantes
    {
        private readonly IRepositorioEstudiantes _repositorio;
        public ServiciosEstudiantes()
        {
            _repositorio = new RepositorioEstudiantes();
        }

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

        public int GetCantidad(string textoFiltro = null)
        {
            try
            {
                return _repositorio.GetCantidad(textoFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Estudiante> GetEstudiantesPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro = null)
        {
            try
            {
                return _repositorio.GetEstudiantesPorPagina(registrosPorPagina, paginaActual, textoFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

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

    }
}
