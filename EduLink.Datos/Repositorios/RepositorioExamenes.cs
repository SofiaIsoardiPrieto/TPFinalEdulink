using Dapper;
using EduLink.Datos.Helper;
using EduLink.Datos.Interfaces;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace EduLink.Datos.Repositorios
{
    public class RepositorioExamenes : IRepositorioExamenes
    {

        public RepositorioExamenes()
        {

        }
        /// <summary>
        /// Verifica si ya existe un examen para la misma materia en la misma fecha, evitando así duplicados.
        /// </summary>
        /// <param name="examen"></param>
        /// <returns></returns>
        public bool Existe(Examen examen)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                int cantidad = conn.ExecuteScalar<int>(
                    "sp_ExisteExamen",
                    new { ExamenId = examen.ExamenId, FechaExamen = examen.FechaExamen },
                    commandType: CommandType.StoredProcedure
                );

                return cantidad > 0;
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
            using (var conn = ConexionBD.GetConexion())
            {
                int cantidad = conn.ExecuteScalar<int>(
                    "sp_EstaRelacionadoExamen",
                    new { ExamenId = examenId },
                    commandType: CommandType.StoredProcedure
                );
                return cantidad > 0;

            }
        }
        /// <summary>
        /// Crear un examen en la base de datos.
        /// </summary>
        /// <param name="examen"></param>
        public void Agregar(Examen examen)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                conn.Execute(
                    "sp_InsertExamen",
                    new
                    {
                        MateriaId = examen.MateriaId,
                        FechaExamen = examen.FechaExamen,
                        HoraComienzo = examen.HoraComienzo
                    },
                    commandType: CommandType.StoredProcedure
                );
            }
        }
        /// <summary>
        /// Editar un examen
        /// </summary>
        /// <param name="examen"></param>
        public void Editar(Examen examen)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                conn.Execute(
                    "sp_EditarExamen",
                     new
                     {
                         ExamenId = examen.ExamenId,
                         FechaExamen = examen.FechaExamen,
                         HoraComienzo = examen.HoraComienzo
                     },
                    commandType: CommandType.StoredProcedure
                );
            }
        }
        /// <summary>
        /// Borar un examen
        /// </summary>
        /// <param name="examenId"></param>
        public void Borrar(int examenId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                conn.Execute(
                    "sp_BorrarExamen",
                     new
                     {
                         ExamenId = examenId

                     },
                    commandType: CommandType.StoredProcedure
                );
            }
        }
        /// <summary>
        /// Obtener la cantidad de examenes de ese año de una  carrera
        /// </summary>
        /// <param name="carreraId"></param>
        /// <returns></returns>

        public int GetCantidad(int carreraId)
        {

            using (var conn = ConexionBD.GetConexion())
            {

                return conn.ExecuteScalar<int>(
                    "sp_GetCantidadExamenes",
                    new { CarreraId = carreraId },
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        /// <summary>
        /// Obtener un examen segun su Id
        /// </summary>
        /// <param name="examenId"></param>
        /// <returns></returns>
        public Examen GetExamenPorId(int examenId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.QuerySingleOrDefault<Examen>(
                    "sp_GetExamenPorId",
                    new { ExamenId = examenId },
                    commandType: CommandType.StoredProcedure
                );
            }
        }
/// <summary>
/// Paginar los examenes de una carrera.
/// </summary>
/// <param name="carreraId"></param>
/// <param name="cantidadPorPagina"></param>
/// <param name="paginaActual"></param>
/// <returns></returns>

        public List<ExamenDto> GetExamenesPorPagina(int carreraId, int cantidadPorPagina, int paginaActual)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.Query<ExamenDto>(
                    "sp_GetExamenesPorPagina",
                    new { CarreraId = carreraId, CantidadPorPagina = cantidadPorPagina, PaginaActual = paginaActual },
                    commandType: CommandType.StoredProcedure
                ).ToList();
            }
        }
        /// <summary>
        /// Obtener los examenes a los que esta inscripto un estudiante, paginados.
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <param name="examenid"></param>
        /// <param name="cantidadPorPagina"></param>
        /// <param name="paginaActual"></param>
        /// <returns></returns>
        public List<EstudianteDto> GetEstudiantesPorExamenPorPagina(int estudianteId, int examenid, int cantidadPorPagina, int paginaActual)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.Query<EstudianteDto>(
                    "sp_GetEstudiantesPorExamanPorPagina",
                    new { EstudianteId = estudianteId, ExamenId = examenid, CantidadPorPagina = cantidadPorPagina, PaginaActual = paginaActual },
                    commandType: CommandType.StoredProcedure
                ).ToList();
            }
        }
        /// <summary>
        /// Guardar la nota de un estudiante para un examen específico. 
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <param name="examenid"></param>
        /// <param name="nota"></param>

        public void InsertNotaEstudianteExamen(int estudianteId, int examenid, int nota)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                conn.Execute(
                   "sp_InsertNotaEstudianteExamen",
                   new
                   {
                       EstudianteId = estudianteId,
                       ExamenId = examenid,
                       Nota = nota
                   },
                   commandType: CommandType.StoredProcedure
               );
            }
        }




    }
}

