using EduLink.Entidades.Entidades;
using EduLink.Entidades.Enums;
using System;
using System.Collections.Generic;

namespace EduLink.Entidades.Dtos
{
    public class HistorialEstudianteExamenDto
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

            // Lista de materias aprobadas
            public List<EstudianteExamenDto> MateriasAprobadas { get; set; } = new List<EstudianteExamenDto>();
       

    }
}
