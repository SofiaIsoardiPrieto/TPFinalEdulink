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
        public List<ModuloDto> Modulos { get; set; } = new List<ModuloDto>(); 
        
        // Propiedad calculada para mostrar en la grilla
        public string DiasYHorarios => string.Join(" | ", Modulos.Select(m => $"{m.Dia} {m.Horario}"));
        public bool CondicionLibre { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
