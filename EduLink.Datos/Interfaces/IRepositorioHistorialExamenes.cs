using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Datos.Interfaces
{
    public interface IRepositorioHistorialExamenes
    {
        int GetCantidad(int estudianteId);
        List<EstudianteHistorialExamenDto> GetHistorialExamenesPorPagina(int estudianteId, int registrosPorPagina, int paginaActual);
        List<EstudianteHistorialExamenDto> GetHistorialExamenesCompleto(int estudianteId);
    }
}

