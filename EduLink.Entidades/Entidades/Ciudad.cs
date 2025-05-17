﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLink.Entidades.Entidades
{
    public class Ciudad:ICloneable
    {
        public int CiudadId { get; set; }
        public string NombreCiudad { get; set; }

        public ICollection<Estudiante> Estudiantes { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
