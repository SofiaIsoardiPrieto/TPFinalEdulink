using Dapper;
using EduLink.Datos.Helper;
using EduLink.Datos.Interfaces;
using System.Data;

namespace EduLink.Datos.Repositorios
{
    public class RepositorioAdministradores : IRepositorioAdministradores
    {

        public RepositorioAdministradores()
        {

        }
        /// <summary>
        /// Validar los datos de inicio de sesión del administrador
        /// </summary>
        /// <param name="codigoAdmin"></param>
        /// <param name="contrasenia"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>

        public int? ValidarInicioSesion(string codigoAdmin, string contrasenia)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.ExecuteScalar<int?>(
                    "sp_GetAdminInicioSesion",
                    new { Codigo = codigoAdmin, Contrasenia = contrasenia },
                    commandType: CommandType.StoredProcedure
                );
            }
        }


    }
}

