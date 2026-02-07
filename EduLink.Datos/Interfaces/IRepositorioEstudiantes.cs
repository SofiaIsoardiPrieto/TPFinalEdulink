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
        int GetCantidad(int carreraId, int? edadMin = null, int? edadMax = null, int? anioAlta = null, int? ciudadId = null, string estado = null); List<EstudianteDto> GetEstudiantesPorPagina(int carreraId, int cantidadPorPagina, int paginaActual, int? edadMin = null, int? edadMax = null, int? anioAlta = null, int? ciudadId = null, string estado = null);
        List<EstudianteCombo> GetEstudiantesCombo();
        Estudiante GetEstudiantePorId(int estudianteId1);
        EstudianteDto GetEstudiantePorDNI(int dni);
        EstudianteDto GetEstudiantePorLegajo(int legajo);
    }
}

