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
    public class RepositorioCarreras : IRepositorioCarreras
    {

        public RepositorioCarreras()
        {

        }
        /// <summary>
        /// Trae la lista de carreras para el combo segun el administrador logueado
        /// </summary>
        /// <param name="adminId"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public List<CarreraCombo> GetCarreraCombo(int? adminId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                var lista = conn.Query<CarreraCombo>(
                    "sp_GetCarrerasPorAdmin",
                    new { AdministradorId = adminId },
                    commandType: CommandType.StoredProcedure
                ).ToList();

                return lista;
            }
        }

        public Carrera GetCarreraPorId(int carreraId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                var carrera = conn.QuerySingleOrDefault<Carrera>(
                    "sp_GetCarreraPorId",
                    new { CarreraId = carreraId },
                    commandType: CommandType.StoredProcedure
                );

                return carrera;
            }
        }
    }
}

