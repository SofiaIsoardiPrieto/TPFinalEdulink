using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLink.Entidades.Entidades
{
    public class Carrera
    {
        public int CarreraId { get; set; }
        public string NombreCarrera { get; set; }
        public int AdministradorId { get; set; }
        public Administrador Administrador{ get; set; }
    }
}
