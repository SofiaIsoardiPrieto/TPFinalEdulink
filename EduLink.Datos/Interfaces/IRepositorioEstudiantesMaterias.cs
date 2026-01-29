using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Datos.Interfaces
{
    public interface IRepositorioEstudiantesMaterias
    {
        void Agregar(int estudianteId, int materiaId);
        void Editar(int estudianteId, int materiaId);
        int GetCantidad(int estudianteId);
        List<MateriaDto> GetEstudiantesPorPagina(int estudianteId, int registrosPorPagina, int paginaActual);
    }
}

