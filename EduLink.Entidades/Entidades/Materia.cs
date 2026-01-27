using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLink.Entidades.Entidades
{
    public class Materia : ICloneable
    {
        public int MateriaId { get; set; }
        public string NombreMateria { get; set; }
        public int AnioCarrera { get; set; }
        public DateTime Fecha { get; set; }   // si la usás para registrar alta/creación
        public int Cuatrimestre { get; set; }

        // Relación con Módulo
        public int ModuloId { get; set; }
        public Modulo Modulo { get; set; }

        // Relación con Carrera
        public int CarreraId { get; set; }
        public Carrera Carrera { get; set; }

        public bool CondicionLibre { get; set; }

        // Relación con correlativas (muchos-a-muchos)
        public ICollection<Correlativa> Correlativas { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

}
