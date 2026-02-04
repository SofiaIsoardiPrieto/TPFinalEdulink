using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Servicios.Interfaces
{
    public interface IServiciosEstudiantesExamenes
    {
        void Borrar(int examenId);
        bool EstaRelacionado(int examenId);
        int GetCantidad(int carreraId);
        List<ExamenDto> GetExamenesPorPagina(int carreraId, int registrosPorPagina, int paginaActual);
        Examen GetExamenPorId(int examenId);
    }
}
