using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Datos.Interfaces
{
    public interface IRepositorioEstudiantesMaterias
    {
        int GetCantidad(int estudianteId);
        List<MateriaDto> GetEstudiantesPorPagina(int estudianteId, int registrosPorPagina, int paginaActual);
    }
}

