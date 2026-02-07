using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Datos.Interfaces
{
    public interface IRepositorioEstudiantesExamen
    {
        void Editar(EstudianteExamenDto estudianteExamenDto);
        int GetCantidad(int examenId);
        List<EstudianteExamenDto> GetEstudiantesExamenPorPagina(int examenId, int registrosPorPagina, int paginaActual);
    }
}

