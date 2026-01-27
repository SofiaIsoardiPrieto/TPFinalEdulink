using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLink.Entidades.Entidades
{
    public class Correlativa:ICloneable
    {
        public int CorrelatividadId { get; set; }
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }
        public int CorrelativaId { get; set; }
        public Materia MateriaCorrelativa { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
