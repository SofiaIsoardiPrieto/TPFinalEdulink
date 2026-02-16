using EduLink.Entidades.Entidades;
using EduLink.Entidades.Enums;
using System;
using System.Collections.Generic;

namespace EduLink.Entidades.Dtos
{
    public class EstudianteHistorialMateriaDto
    {
        // Datos del estudiante
        public int EstudianteId { get; set; }
        public int Legajo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }

        // Carrera
        public int CarreraId { get; set; }
        public string NombreCarrera { get; set; }

        // Ciclo lectivo
        public int AnioCicloLectivo { get; set; }

        // Materia
        public int MateriaId { get; set; }
        public string NombreMateria { get; set; }
        public int? Nota { get; set; }
        public Estado EstadoMateria { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

}
