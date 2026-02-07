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
        int GetCantidad(int carreraId, int? edadMin = null, int? edadMax = null, int? anioAlta = null, int? ciudadId = null, string estado = null); List<EstudianteDto> GetEstudiantesPorPagina(int carreraId, int cantidadPorPagina, int paginaActual, int? edadMin = null, int? edadMax = null, int? anioAlta = null, int? ciudadId = null, string estado = null);
        List<EstudianteCombo> GetEstudiantesCombo();
        Estudiante GetEstudiantePorId(int estudianteId1);
        EstudianteDto GetEstudiantePorDNI(int dni);
        EstudianteDto GetEstudiantePorLegajo(int legajo);
    }
}
