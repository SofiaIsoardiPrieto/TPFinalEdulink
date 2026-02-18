using Dapper;
using EduLink.Datos.Helper;
using EduLink.Datos.Interfaces;
using EduLink.Entidades.Combos;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace EduLink.Datos.Repositorios
{
    public class RepositorioCiudades : IRepositorioCiudades
    {

        public RepositorioCiudades()
        {

        }
       /// <summary>
       /// Trae la lista de ciudad para el bombobox
       /// </summary>
       /// <returns></returns>
        public List<CiudadCombo> GetCiudadesCombo()
        {
            using (var conn = ConexionBD.GetConexion())
            {
                var lista = conn.Query<CiudadCombo>(
                    "sp_GetCiudades",
                    commandType: CommandType.StoredProcedure
                ).ToList();

                return lista;
            }
        }


    }
}

