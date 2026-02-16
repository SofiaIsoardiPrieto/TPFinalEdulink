using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Servicios.Interfaces
{
    public interface IServiciosHistorialMaterias
    {
        int GetCantidad(int estudianteId);
        List<EstudianteHistorialMateriaDto> GetHistorialMateriaPorPagina(int estudianteId, int registrosPorPagina, int paginaActual);
        List<EstudianteHistorialMateriaDto> GetHistorialMateriasCompleto(int estudianteId);
    }
}
