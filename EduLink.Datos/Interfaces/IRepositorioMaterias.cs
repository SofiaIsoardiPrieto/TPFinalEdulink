using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Datos.Interfaces
{
    public interface IRepositorioMaterias
    {
        //void Agregar(Examen examen);
        //void Borrar(int examenId);
        //void Editar(Examen examen);
        //bool EstaRelacionado(int examenId);
        //bool Existe(Examen examen);
        //int GetCantidad(int carreraId);
        //List<ExamenDto> GetExamenesPorPagina(int carreraId, int registrosPorPagina, int paginaActual);
        //Examen GetExamenPorId(int examenId);
        int GetCantidad(int carreraId);
        List<Materia> GetMateriasPorPagina(int carreraId, int registrosPorPagina, int paginaActual);
    }
}

