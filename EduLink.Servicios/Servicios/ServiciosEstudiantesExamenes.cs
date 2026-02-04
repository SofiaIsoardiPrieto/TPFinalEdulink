using EduLink.Datos.Interfaces;
using EduLink.Datos.Repositorios;
using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using EduLink.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace EduLink.Servicios.Servicios
{
    public class ServiciosEstudiantesExamenes : IServiciosEstudiantesExamenes
    {
        private readonly IRepositorioEstudiantesExamenes _repositorio;
        public ServiciosEstudiantesExamenes()
        {
            _repositorio = new RepositorioEstudiantesExamenes();
        }

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
        /// <summary>
        /// Trae la cantidad de materias disponibles (filtra por correlativas) de un estudiante
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <returns></returns>
        public int GetCantidad(int estudianteId, int anioMateria, bool inscripto)
        {
            try
            {
                return _repositorio.GetCantidad(estudianteId, anioMateria,  inscripto);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Trae las materias disponibles (filtra por correlativas) de un estudiante por pagina
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <param name="registrosPorPagina"></param>
        /// <param name="paginaActual"></param>
        /// <returns></returns>

        public List<MateriaDto> GetPorPagina(int carreraId, int registrosPorPagina, int paginaActual)
        {
            try
            {
                return _repositorio.GetEstudiantesPorPagina(carreraId, registrosPorPagina, paginaActual);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ExamenDto> GetExamenesPorEstudiantePorPagina(int estudianteId, int anioMateria, bool inscripto, int registrosPorPagina, int paginaActual)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int examenId)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(int examenId)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad(int carreraId)
        {
            throw new NotImplementedException();
        }

        public List<ExamenDto> GetExamenesPorPagina(int carreraId, int registrosPorPagina, int paginaActual)
        {
            throw new NotImplementedException();
        }

        public Examen GetExamenPorId(int examenId)
        {
            throw new NotImplementedException();
        }
    }
}
