using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Servicios.Interfaces
{
    public interface IServiciosEstudiantes
    {
       
        bool Existe(Estudiante estudiante);
        void Guardar(Estudiante estudiante); // en guardar está el agregar y editar
        bool EstaRelacionado(int estudianteId);
        void Borrar(int estudianteId);
        int GetCantidad(string textoFiltro = null);
        List<EstudianteDto> GetEstudiantesPorPagina(int cantidadPorPagina, int paginaActual, string textoFiltro = null);
        List<EstudianteCombo> GetEstudiantesCombo();
        Estudiante GetEstudiantePorId(int estudianteId);
    }
}
