using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Datos.Interfaces
{
    public interface IRepositorioEstudiantes
    {

        void Agregar(Estudiante estudiante);     
        bool Existe(Estudiante estudiante);
        void Editar(Estudiante estudiante);
        bool EstaRelacionado(int estudianteId);
        void Borrar(int estudianteId);
        int GetCantidad(int carreraId, string textoFiltro = null);
        List<EstudianteDto> GetEstudiantesPorPagina(int cantidadPorPagina, int paginaActual, int paginaActual1, string textoFiltro = null);
        List<EstudianteCombo> GetEstudiantesCombo();
        Estudiante GetEstudiantePorId(int estudianteId1);
    }
}

