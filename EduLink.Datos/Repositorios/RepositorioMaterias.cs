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
    public class RepositorioMaterias : IRepositorioMaterias
    {

        public RepositorioMaterias()
        {

        }



        public int GetCantidad(int carreraId)
        {

            using (var conn = ConexionBD.GetConexion())
            {

                return conn.ExecuteScalar<int>(
                    "sp_GetCantidadMaterias",
                    new { CarreraId = carreraId },
                    commandType: CommandType.StoredProcedure
                );
            }
        }




        public List<Materia> GetMateriasPorPagina(int carreraId, int cantidadPorPagina, int paginaActual)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.Query<Materia>(
                    "sp_GetMateriasPorPagina",
                    new { CarreraId = carreraId, CantidadPorPagina = cantidadPorPagina, PaginaActual = paginaActual },
                    commandType: CommandType.StoredProcedure
                ).ToList();
            }
        }

       
        




    }
}

