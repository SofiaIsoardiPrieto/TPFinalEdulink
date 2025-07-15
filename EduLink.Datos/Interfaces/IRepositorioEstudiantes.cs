using EduLink.Entidades.Combos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Datos.Interfaces
{
    public interface IRepositorioEstudiantes
    {

        bool Existe(Estudiante estudiante);
        void Agregar(Estudiante estudiante);
        void Editar(Estudiante estudiante);
        int GetCantidad(string textoFiltro = null);
        List<Estudiante> GetEstudiantesPorPagina(int cantidadPorPagina, int paginaActual, string textoFiltro = null);
        void Borrar(int estudianteId);
        List<EstudianteCombo> GetEstudiantesCombo();

    }
}

