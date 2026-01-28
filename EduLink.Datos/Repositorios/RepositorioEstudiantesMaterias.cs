using Dapper;
using EduLink.Datos.Helper;
using EduLink.Datos.Interfaces;
using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;

namespace EduLink.Datos.Repositorios
{
    public class RepositorioEstudiantesMaterias : IRepositorioEstudiantesMaterias
    {

        public RepositorioEstudiantesMaterias()
        {

        }
       

        public int GetCantidad(int estudianteId)
        {
           
            using (var conn = ConexionBD.GetConexion())
            {

                return conn.ExecuteScalar<int>(
                    "sp_GetCantidadMateriasPorEstudiante",
                    new { estudianteId=estudianteId },
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public List<MateriaDto> GetEstudiantesPorPagina(int estudianteId, int registrosPorPagina, int paginaActual)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.Query<MateriaDto>(
                    "sp_GetMateriasPorEstudiantePorPagina",
                    new { EstudianteId = estudianteId, CantidadPorPagina = registrosPorPagina, PaginaActual = paginaActual },
                    commandType: CommandType.StoredProcedure
                ).ToList();
            }
        }

        

    }
}

