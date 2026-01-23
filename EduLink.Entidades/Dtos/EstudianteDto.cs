using EduLink.Entidades.Entidades;
using System;
using System.Collections.Generic;

namespace EduLink.Entidades.Dtos
{
    public class EstudianteDto
    {
        public int EstudianteId { get; set; }       // <-- Agregado
        public int Legajo { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string EstadoEstudiante { get; set; }
        public string NombreCiudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaAlta { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
