using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLink.Entidades.Entidades
{
    public class EstudianteExamen:ICloneable
    {
        public int EstudianteExamenId { get; set; }
        public int EstudianteId { get; set; }
        public int ExamenId { get; set; }
        public decimal Nota { get; set; }
        public string EstadoExamen { get; set; }

        public Estudiante Estudiante { get; set; } 
        public Examen Examen { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
