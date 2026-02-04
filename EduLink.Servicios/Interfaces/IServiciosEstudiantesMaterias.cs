using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Servicios.Interfaces
{
    public interface IServiciosEstudiantesMaterias
    {
        void Borrar(int estudianteId, int materiaId);
        bool Existe(int estudianteId, int materiaId);
        int GetCantidad(int estudianteId, int? anioMateria);
        List<MateriaCombo> GetMateriasCombo(int carreraId);
        List<MateriaDto> GetMateriasPorEstudiantePorPagina(int estudianteId, int? anioMateria,  int registrosPorPagina, int paginaActual);
        void Guardar(int estudianteId, int materiaId);
    }
}
