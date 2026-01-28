using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLink.Entidades.Entidades
{
    public class ModuloDto:ICloneable
    {
        public string Dia { get; set; }
        public string Horario { get; set; } // Ej: "08:00 - 10:00"
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
