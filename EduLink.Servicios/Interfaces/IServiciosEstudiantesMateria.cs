using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Servicios.Interfaces
{
    public interface IServiciosEstudiantesMateria
    {
        int GetCantidad(int materiaId);
        List<EstudianteMateriaDto> GetEstudiantesMateriaPorPagina(int materiaId, int registrosPorPagina, int paginaActual);
        void Guardar(EstudianteMateriaDto estudianteMateriaDto);
    }
}
