using EduLink.Entidades.Combos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Datos.Interfaces
{
    public interface IRepositorioInscripcionMaterias
    {
        void Agregar(int estudianteId, int materiaId);
        void Borrar(int estudianteId, int materiaId);
        void Editar(int estudianteId, int materiaId);
        bool Existe(int estudianteId, int materiaId);
        int GetCantidad(int estudianteId, int? anioMateria);
        List<MateriaDto> GetEstudiantesPorPagina(int estudianteId, int? anioMateria, int registrosPorPagina, int paginaActual);
        List<MateriaCombo> GetMateriasCombo(int carreraId);
    }
}

