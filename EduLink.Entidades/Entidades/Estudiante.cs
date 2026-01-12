using EduLink.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLink.Entidades.Entidades
{
    public class Estudiante:ICloneable
    {
        public int EstudianteId { get; set; }
        public int Legajo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public EstadoEstudiante EstadoEstudiante { get; set; }

        //agregar carreraid
        public int CarreraId { get; set; }
        public Carrera Carrera { get; set; }

        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }

        public ICollection<EstudianteMateria> EstudiantesMaterias { get; set; }
        public ICollection<EstudianteExamen> EstudiantesExamenes { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
