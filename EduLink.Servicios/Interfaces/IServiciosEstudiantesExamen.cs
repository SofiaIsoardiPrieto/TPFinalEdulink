using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Servicios.Interfaces
{
    public interface IServiciosEstudiantesExamen
    {
        int GetCantidad(int examenId);
        List<EstudianteExamenDto> GetEstudiantesExamenPorPagina(int examenId, int registrosPorPagina, int paginaActual);
        void Guardar(EstudianteExamenDto estudianteExamenDto);
    }
}
