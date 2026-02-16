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

