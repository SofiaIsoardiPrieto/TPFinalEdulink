using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLink.Entidades.Entidades
{
    public class MateriaDto:ICloneable
    {
        public int MateriaId { get; set; }
        public string NombreMateria { get; set; }
        public int AnioDeLaMateria { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public bool CondicionLibre { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
