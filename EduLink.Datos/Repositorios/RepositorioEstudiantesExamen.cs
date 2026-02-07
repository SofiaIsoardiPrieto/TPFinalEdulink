using Dapper;
using EduLink.Datos.Helper;
using EduLink.Datos.Interfaces;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace EduLink.Datos.Repositorios
{
    public class RepositorioEstudiantesExamen: IRepositorioEstudiantesExamen
    {

        public RepositorioEstudiantesExamen()
        {

        }
        public bool Existe(Examen examen)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                int cantidad = conn.ExecuteScalar<int>(
                    "sp_ExisteExamen",
                    new { ExamenId = examen.ExamenId, FechaExamen = examen.FechaExamen },
                    commandType: CommandType.StoredProcedure
                );

                return cantidad > 0;
            }
        }
        public bool EstaRelacionado(int examenId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                int cantidad = conn.ExecuteScalar<int>(
                    "sp_EstaRelacionadoExamen",
                    new { ExamenId = examenId },
                    commandType: CommandType.StoredProcedure
                );
                return cantidad > 0;

            }
        }
        public void Agregar(Examen examen)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                conn.Execute(
                    "sp_InsertExamen",
                    new
                    {
                        MateriaId = examen.MateriaId,
                        FechaExamen = examen.FechaExamen,
                        HoraComienzo = examen.HoraComienzo
                    },
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public void Editar(Examen examen)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                conn.Execute(
                    "sp_EditarExamen",
                     new
                     {
                         ExamenId = examen.ExamenId,
                         FechaExamen = examen.FechaExamen,
                         HoraComienzo = examen.HoraComienzo
                     },
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public void Borrar(int examenId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                conn.Execute(
                    "sp_BorrarExamen",
                     new
                     {
                         ExamenId = examenId

                     },
                    commandType: CommandType.StoredProcedure
                );
            }
        }


        public int GetCantidad(int carreraId)
        {

            using (var conn = ConexionBD.GetConexion())
            {

                return conn.ExecuteScalar<int>(
                    "sp_GetCantidadExamenes",
                    new { CarreraId = carreraId },
                    commandType: CommandType.StoredProcedure
                );
            }
        }


        public Examen GetExamenPorId(int examenId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.QuerySingleOrDefault<Examen>(
                    "sp_GetExamenPorId",
                    new { ExamenId = examenId },
                    commandType: CommandType.StoredProcedure
                );
            }
        }


        public List<ExamenDto> GetExamenesPorPagina(int carreraId, int cantidadPorPagina, int paginaActual)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.Query<ExamenDto>(
                    "sp_GetExamenesPorPagina",
                    new { CarreraId = carreraId, CantidadPorPagina = cantidadPorPagina, PaginaActual = paginaActual },
                    commandType: CommandType.StoredProcedure
                ).ToList();
            }
        }

        public List<EstudianteDto> GetEstudiantesPorExamenPorPagina(int estudianteId, int examenid, int cantidadPorPagina, int paginaActual)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.Query<EstudianteDto>(
                    "sp_GetEstudiantesPorExamanPorPagina",
                    new { EstudianteId = estudianteId, ExamenId = examenid, CantidadPorPagina = cantidadPorPagina, PaginaActual = paginaActual },
                    commandType: CommandType.StoredProcedure
                ).ToList();
            }
        }

        public void InsertNotaEstudianteExamen(int estudianteId, int examenid, int nota)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                conn.Execute(
                   "sp_InsertNotaEstudianteExamen",
                   new
                   {
                       EstudianteId = estudianteId,
                       ExamenId = examenid,
                       Nota = nota
                   },
                   commandType: CommandType.StoredProcedure
               );
            }
        }




    }
}

