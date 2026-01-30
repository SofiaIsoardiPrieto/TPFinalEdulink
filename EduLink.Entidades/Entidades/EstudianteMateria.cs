using EduLink.Entidades.Enums;
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
        public int AnioCursado { get; set; }
        public int Nota { get; set; }
        public Estado EstadoMateria { get; set; }

        public Estudiante Estudiante { get; set; } 
        public Materia Materia { get; set; }
        public bool EsLibre { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
