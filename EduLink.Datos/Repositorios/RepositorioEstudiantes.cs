using Dapper;
using EduLink.Datos.Helper;
using EduLink.Datos.Interfaces;
using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace EduLink.Datos.Repositorios
{
    public class RepositorioEstudiantes : IRepositorioEstudiantes
    {

        public RepositorioEstudiantes()
        {

        }

        /// <summary>
        /// Agrega un estudiante a la base de datos
        /// </summary>
        /// <param name="estudiante"></param>
        public void Agregar(Estudiante estudiante)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                int id = conn.QuerySingle<int>(
                    "sp_InsertEstudiante",
                    estudiante,
                    commandType: CommandType.StoredProcedure
                );

                estudiante.EstudianteId = id;
            }
        }

        /// <summary>
        /// Determina si ya existe un estudiante en la base de datos
        /// </summary>
        /// <param name="estudiante"></param>
        /// <returns></returns>
        public bool Existe(Estudiante estudiante)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                int cantidad = conn.ExecuteScalar<int>(
                    "sp_ExisteEstudiante",
                    estudiante,
                    commandType: CommandType.StoredProcedure
                );

                return cantidad > 0;
            }
        }

        /// <summary>
        /// Edita un estudiante en la base de datos
        /// </summary>
        /// <param name="estudiante"></param>
        public void Editar(Estudiante estudiante)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                conn.Execute(
                    "sp_UpdateEstudiante",
                    estudiante,
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        /// <summary>
        /// Determina si hay un estudiante relacionado con alguna otra tabla
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <returns></returns>
        public bool EstaRelacionado(int estudianteId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                int cantidad = conn.ExecuteScalar<int>(
                    "sp_EstudianteRelacionado",
                    new { EstudianteId = estudianteId },
                    commandType: CommandType.StoredProcedure
                );

                return cantidad > 0;
            }
        }

        /// <summary>
        /// Borra un estudiante de la base de datos
        /// </summary>
        /// <param name="estudianteId"></param>
        public void Borrar(int estudianteId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                conn.Execute(
                    "sp_DeleteEstudiante",
                    new { EstudianteId = estudianteId },
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        /// <summary>
        /// Obtiene la cantidad de registros de estudiantes, si se pasa un textoFiltro, 
        /// filtra por apellido que comienze con ese texto
        /// </summary>
        /// <param name="textoFiltro"></param>
        /// <returns></returns>
        public int GetCantidad(int carreraId, string textoFiltro = null)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                int cantidad = conn.ExecuteScalar<int>(
                    "sp_GetCantidadEstudiantes",
                    new { TextoFiltro = textoFiltro },
                    commandType: CommandType.StoredProcedure
                );

                return cantidad;
            }
        }

        /// <summary>
        /// Devuelve una lista de estudiantes paginada, 
        /// si se pasa un textoFiltro, filtra por apellido que comienze con ese texto
        /// </summary>
        /// <param name="cantidadPorPagina"></param>
        /// <param name="paginaActual"></param>
        /// <param name="textoFiltro"></param>
        /// <returns></returns>
        public List<EstudianteDto> GetEstudiantesPorPagina(int carreraId, int cantidadPorPagina, int paginaActual, string textoFiltro = null)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                var lista = conn.Query<EstudianteDto>(
                    "sp_GetEstudiantesPorPagina",
                    new { CantidadPorPagina = cantidadPorPagina, PaginaActual = paginaActual, TextoFiltro = textoFiltro },
                    commandType: CommandType.StoredProcedure
                ).ToList();

                return lista;
            }
        }

        /// <summary>
        /// Recive una lista de estudiantes para llenar un combo
        /// </summary>
        /// <returns></returns>
        public List<EstudianteCombo> GetEstudiantesCombo()
        {
            using (var conn = ConexionBD.GetConexion())
            {
                var lista = conn.Query<EstudianteCombo>(
                    "sp_GetEstudiantesCombo",
                    commandType: CommandType.StoredProcedure
                ).ToList();

                return lista;
            }
        }

        public Estudiante GetEstudiantePorId(int id)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.QuerySingleOrDefault<Estudiante>(
                    "sp_GetEstudiantePorId",
                    new { EstudianteId = id },
                    commandType: CommandType.StoredProcedure
                );
            }
        }
    }
}

