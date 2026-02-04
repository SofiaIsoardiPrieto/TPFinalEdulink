using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLink.Entidades.Entidades
{
    public class ExamenDto:ICloneable
    {
        public int ExamenId { get; set; }
        public int MateriaId { get; set; }
        public int AnioCarrera { get; set; }
        public string NombreMateria { get; set; }
        public DateTime FechaExamen { get; set; }
        public TimeSpan HoraComienzo { get; set; }
        public bool EsLibre { get; set; } // atributo de la materia
        public int CarreraId { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
