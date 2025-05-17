using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLink.Entidades.Entidades
{
    public class Modulo:ICloneable
    {
        public int ModuloId { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public ICollection<Materia> Materias { get; set; }


        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
