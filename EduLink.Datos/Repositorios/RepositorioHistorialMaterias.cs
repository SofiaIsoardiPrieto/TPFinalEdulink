using Dapper;
using EduLink.Datos.Helper;
using EduLink.Datos.Interfaces;
using EduLink.Entidades.Dtos;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace EduLink.Datos.Repositorios
{
    public class RepositorioHistorialMaterias : IRepositorioHistorialMaterias
    {

        public RepositorioHistorialMaterias()
        {

        }

        /// <summary>
        /// Obtiene la cantidad de materias aprobadas por un estudiante.
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <returns></returns>
        public int GetCantidad(int estudianteId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.ExecuteScalar<int>(
                    "sp_GetCantidadHistorialMaterias",
                    new { EstudianteId = estudianteId },
                    commandType: CommandType.StoredProcedure
                );
            }
        }
        /// <summary>
        /// Pagina las materia aprobadas por un estudiante.
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <param name="registrosPorPagina"></param>
        /// <param name="paginaActual"></param>
        /// <returns></returns>

        public List<EstudianteHistorialMateriaDto> GetHistorialMateriaPorPagina(int estudianteId, int registrosPorPagina, int paginaActual)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.Query<EstudianteHistorialMateriaDto>(
                    "sp_GetHistorialMateriasPorPagina",
                    new { EstudianteId = estudianteId, CantidadPorPagina = registrosPorPagina, PaginaActual = paginaActual },
                    commandType: CommandType.StoredProcedure
                ).ToList();
            }
        }
        /// <summary>
        /// Trea la lista completa de materias aprobadas por un estudiante, sin paginar. Se utiliza para exportar a pdf.
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <returns></returns>
        public List<EstudianteHistorialMateriaDto> GetHistorialMateriasCompleto(int estudianteId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.Query<EstudianteHistorialMateriaDto>(
                    "sp_GetHistorialMateriasCompleto",
                    new { EstudianteId = estudianteId },
                    commandType: CommandType.StoredProcedure
                ).ToList();
            }
        }

    }
}

