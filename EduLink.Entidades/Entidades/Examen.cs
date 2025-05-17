using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLink.Entidades.Entidades
{
    public class Examen:ICloneable
    {
        public int ExamenId { get; set; }
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }
        public TimeSpan HoraComienzo { get; set; }
        public DateTime FechaExamen { get; set; }
        public ICollection<EstudianteExamen> EstudiantesExamenes { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
