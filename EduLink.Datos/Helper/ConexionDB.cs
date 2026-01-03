using System.Configuration;
using System.Data.SqlClient;

namespace EduLink.Datos.Helper
{
    public static class ConexionBD
    {
        public static SqlConnection GetConexion()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            return new SqlConnection(cadenaConexion);
        }
    }
}
