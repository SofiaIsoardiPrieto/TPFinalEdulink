using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Datos.Interfaces
{
    public interface IRepositorioInscripcionExamenes
    {
        bool Existe(int estudianteId, int examenId);
        int GetCantidad(int estudianteId);

        //void Agregar(Examen examen);
        //void Borrar(int examenId);
        //void Editar(Examen examen);
        //bool EstaRelacionado(int examenId);
        //bool Existe(Examen examen);
        //int GetCantidad(int carreraId);
        //List<ExamenDto> GetExamenesPorPagina(int carreraId, int registrosPorPagina, int paginaActual);
        //Examen GetExamenPorId(int examenId);
        List<ExamenDto> GetExamenesInscripcionEstudiantePorPagina(int estudianteId, int registrosPorPagina, int paginaActual);
        void Guardar(int estudianteId, int examenId);
    }
}

