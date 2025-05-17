using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLink.Entidades.Entidades
{
    public class Materia:ICloneable
    {
        public int MateriaId { get; set; }
        public string NombreMateria { get; set; }
        public int AnioDeLaMateria { get; set; }
        public int Cuatrimestre { get; set; }
        public DateTime Fecha { get; set; }
        public int Correlativa { get; set; }

        public int ModuloId { get; set; }
        public Modulo Modulo { get; set; }

        public ICollection<EstudianteMateria> EstudiantesMaterias { get; set; }
        public ICollection<Examen> Examenes { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
