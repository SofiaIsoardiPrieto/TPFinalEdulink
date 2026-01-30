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
        bool Existe(int estudianteId, int materiaId);
        int GetCantidad(int estudianteId,int anioMateria, bool inscripto);
        List<MateriaDto> GetEstudiantesPorPagina(int estudianteId, int anioMateria, bool inscripto, int registrosPorPagina, int paginaActual);
    }
}

