using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Datos.Interfaces
{
    public interface IRepositorioHistorialMaterias
    {
        int GetCantidad(int estudianteId);
        List<EstudianteHistorialMateriaDto> GetHistorialMateriaPorPagina(int estudianteId, int registrosPorPagina, int paginaActual);
        List<EstudianteHistorialMateriaDto> GetHistorialMateriasCompleto(int estudianteId);
    }
}

