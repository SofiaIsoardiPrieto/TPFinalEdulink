using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Servicios.Interfaces
{
    public interface IServiciosEstudiantesMaterias
    {
        int GetCantidad(int estudianteId);
        List<MateriaDto> GetMateriasPorEstudiantePorPagina(int estudianteId, int registrosPorPagina, int paginaActual);
    }
}
