using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Servicios.Interfaces
{
    public interface IServiciosMaterias
    {
        int GetCantidad(int carreraId);

        // void Borrar(int examenId);
        // bool EstaRelacionado(int examenId);
        // bool Existe(Examen examen);
       

        // Examen GetExamenPorId(int examenId);
        // void Guardar(Examen examen);
        List<Materia> GetMateriasPorPagina(int carreraId, int registrosPorPagina, int paginaActual);
    }
}
