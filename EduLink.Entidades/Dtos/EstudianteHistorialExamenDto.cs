using EduLink.Entidades.Entidades;
using EduLink.Entidades.Enums;
using System;
using System.Collections.Generic;

namespace EduLink.Entidades.Dtos
{
    public class EstudianteHistorialExamenDto
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

        // Examen
        public int ExamenId{ get; set; }
        public DateTime FechaExamen { get; set; }
        public string NombreMateria { get; set; }
        public int? Nota { get; set; }
        public Estado EstadoExamen { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

}
