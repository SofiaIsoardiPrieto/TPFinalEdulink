using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Servicios.Interfaces
{
    public interface IServiciosEstudiantesMaterias
    {
        bool Existe(int estudianteId, int materiaId);
        int GetCantidad(int estudianteId);
        List<MateriaDto> GetMateriasPorEstudiantePorPagina(int estudianteId, int registrosPorPagina, int paginaActual);
        void Guardar(int estudianteId, int materiaId);
    }
}
