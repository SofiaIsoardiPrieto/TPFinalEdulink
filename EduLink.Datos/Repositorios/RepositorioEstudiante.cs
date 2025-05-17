using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLink.Datos.Repositorios
{
    public class RepositorioEstudiante
    {
        private readonly string cadenaConexion;
        public RepositorioEstudiante()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
    }
}
