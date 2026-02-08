using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Servicios.Interfaces
{
    public interface IServiciosInscripcionExamenes
    {
        bool Existe(int estudianteId, int examenId);

        // void Borrar(int examenId);
        // bool EstaRelacionado(int examenId);
        // bool Existe(Examen examen);
        //// int GetCantidad(int carreraId, int anioMateria);
        // int GetCantidad(int carreraId);
        // List<ExamenDto> GetExamenesPorPagina(int carreraId, int registrosPorPagina, int paginaActual);

        // Examen GetExamenPorId(int examenId);
        // void Guardar(Examen examen);
        int GetCantidad(int estudianteId);
        List<ExamenDto> GetExamenesInscripcionEstudiantePorPagina(int estudianteId, int registrosPorPagina, int paginaActual);
        void Guardar(int estudianteId, int examenId);
    }
}
