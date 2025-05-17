using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLink.Entidades.Entidades
{
    public class EstudianteMateria:ICloneable
    {
        public int EstudianteMateriaId { get; set; }
        public int EstudianteId { get; set; }
        public int MateriaId { get; set; }
        public string AnioCursado { get; set; }
        public string EstadoMateria { get; set; }
        public Estudiante Estudiante { get; set; } 
        public Materia Materia { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
