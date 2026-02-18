using Dapper;
using EduLink.Datos.Helper;
using EduLink.Datos.Interfaces;
using EduLink.Entidades.Dtos;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace EduLink.Datos.Repositorios
{
    public class RepositorioHistorialExamenes : IRepositorioHistorialExamenes
    {

        public RepositorioHistorialExamenes()
        {

        }

        /// <summary>
        /// Obtener la cantidad de examenes aprobados por un estudiante
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <returns></returns>
        public int GetCantidad(int estudianteId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.ExecuteScalar<int>(
                    "sp_GetCantidadHistorialExamenes",
                    new { EstudianteId = estudianteId },
                    commandType: CommandType.StoredProcedure
                );
            }
        }
        /// <summary>
        /// Paginas los examenes aprobados por un estudiante.
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <param name="registrosPorPagina"></param>
        /// <param name="paginaActual"></param>
        /// <returns></returns>
        public List<EstudianteHistorialExamenDto> GetHistorialExamenesPorPagina(int estudianteId, int registrosPorPagina, int paginaActual)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.Query<EstudianteHistorialExamenDto>(
                    "sp_GetHistorialExamenesPorPagina",
                    new { EstudianteId = estudianteId, CantidadPorPagina = registrosPorPagina, PaginaActual = paginaActual },
                    commandType: CommandType.StoredProcedure
                ).ToList();
            }
        }
        /// <summary>
        /// Obtener la lista completa (sin paginar) de examenes aprobados por un estudiante, para exportar a pdf.
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <returns></returns>
        public List<EstudianteHistorialExamenDto> GetHistorialExamenesCompleto(int estudianteId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.Query<EstudianteHistorialExamenDto>(
                    "sp_GetHistorialExamenesCompleto",
                    new { EstudianteId = estudianteId },
                    commandType: CommandType.StoredProcedure
                ).ToList();
            }
        }

    }
}

