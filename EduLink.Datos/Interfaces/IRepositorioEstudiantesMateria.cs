using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Datos.Interfaces
{
    public interface IRepositorioEstudiantesMateria
    {
        void Editar(EstudianteMateriaDto estudianteMateriaDto);
        int GetCantidad(int materiaId);
        List<EstudianteMateriaDto> GetEstudiantesMateriaPorPagina(int materiaId, int registrosPorPagina, int paginaActual);
    }
}

