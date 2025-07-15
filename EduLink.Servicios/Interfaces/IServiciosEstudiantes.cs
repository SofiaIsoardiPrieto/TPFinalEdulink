using EduLink.Entidades.Combos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Servicios.Interfaces
{
    internal interface IServiciosEstudiantes
    {
        void Borrar(int estudianteId);
        bool Existe(Estudiante estudiante);
        int GetCantidad(string textoFiltro = null);
        List<Estudiante> GetEstudiantesPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro = null);
        List<EstudianteCombo> GetEstudiantesCombo();
        void Guardar(Estudiante estudiante);


    }
}
