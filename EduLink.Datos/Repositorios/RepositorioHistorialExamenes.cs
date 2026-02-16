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

