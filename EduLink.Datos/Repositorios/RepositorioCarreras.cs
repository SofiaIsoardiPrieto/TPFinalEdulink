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
        public List<Carrera> GetCarreraCombo(int? adminId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                var lista = conn.Query<Carrera>(
                    "sp_GetCarrerasPorAdmin",
                    new { AdminId = adminId },
                    commandType: CommandType.StoredProcedure
                ).ToList();

                return lista;
            }
        }

    }
}

