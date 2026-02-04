using EduLink.Entidades.Enums;
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
        public int AnioCarrera { get; set; }
        public List<ModuloDto> Modulos { get; set; } = new List<ModuloDto>();

        //Para saber si el estudiante ya está inscripto en la materia
        public bool Inscripto { get; set; }

        // Propiedad calculada para mostrar en la grilla
        public string DiasYHorarios => string.Join(" | ", Modulos.Select(m => $"{m.Dia} {m.Horario}"));
        public bool EsLibre { get; set; }

        // Nota numérica (opcional)
        public int? Nota { get; set; } // null si aún sin nota, 0 si ausente
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
