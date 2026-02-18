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
    public class RepositorioEstudiantesMateria : IRepositorioEstudiantesMateria
    {

        public RepositorioEstudiantesMateria()
        {

        }
        /// <summary>
        /// Edita la nota del estudiante inscrpto en una materia y su estado (Aprobado, Reprobado, Ausente)
        /// </summary>
        /// <param name="estudianteMateriaDto"></param>
        public void Editar(EstudianteMateriaDto estudianteMateriaDto)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                conn.Execute(
                    "sp_EditarNotaEstudianteMateria",
                     new
                     {
                         MateriaId = estudianteMateriaDto.MateriaId,
                         EstudianteId = estudianteMateriaDto.EstudianteId,
                         Nota = estudianteMateriaDto.Nota,
                         EstadoMateria = estudianteMateriaDto.EstadoMateria.ToString()
                     },
                    commandType: CommandType.StoredProcedure
                );
            }
        }
        /// <summary>
        /// Obtiene la cantidad de estudiantes anotados en una materia especifica.
        /// </summary>
        /// <param name="materiaId"></param>
        /// <returns></returns>
        public int GetCantidad(int materiaId)
        {

            using (var conn = ConexionBD.GetConexion())
            {

                return conn.ExecuteScalar<int>(
                    "sp_GetCantidadEstudiantesMateria",
                    new { MateriaId = materiaId },
                    commandType: CommandType.StoredProcedure
                );
            }
        }
        /// <summary>
        /// Pagina los estudiante anotados en una materia especifica.
        /// </summary>
        /// <param name="materiaId"></param>
        /// <param name="registrosPorPagina"></param>
        /// <param name="paginaActual"></param>
        /// <returns></returns>
        public List<EstudianteMateriaDto> GetEstudiantesMateriaPorPagina(int materiaId, int registrosPorPagina, int paginaActual)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.Query<EstudianteMateriaDto>(
                    "sp_GetEstudiantesMateriaPorPagina",
                    new { MateriaId = materiaId, CantidadPorPagina = registrosPorPagina, PaginaActual = paginaActual },
                    commandType: CommandType.StoredProcedure
                ).ToList();
            }
        }



        


        //public bool Existe(Examen examen)
        //{
        //    using (var conn = ConexionBD.GetConexion())
        //    {
        //        int cantidad = conn.ExecuteScalar<int>(
        //            "sp_ExisteExamen",
        //            new { ExamenId = examen.ExamenId, FechaExamen = examen.FechaExamen },
        //            commandType: CommandType.StoredProcedure
        //        );

        //        return cantidad > 0;
        //    }
        //}
        //public bool EstaRelacionado(int examenId)
        //{
        //    using (var conn = ConexionBD.GetConexion())
        //    {
        //        int cantidad = conn.ExecuteScalar<int>(
        //            "sp_EstaRelacionadoExamen",
        //            new { ExamenId = examenId },
        //            commandType: CommandType.StoredProcedure
        //        );
        //        return cantidad > 0;

        //    }
        //}
        //public void Agregar(Examen examen)
        //{
        //    using (var conn = ConexionBD.GetConexion())
        //    {
        //        conn.Execute(
        //            "sp_InsertExamen",
        //            new
        //            {
        //                MateriaId = examen.MateriaId,
        //                FechaExamen = examen.FechaExamen,
        //                HoraComienzo = examen.HoraComienzo
        //            },
        //            commandType: CommandType.StoredProcedure
        //        );
        //    }
        //}


        //public void Borrar(int examenId)
        //{
        //    using (var conn = ConexionBD.GetConexion())
        //    {
        //        conn.Execute(
        //            "sp_BorrarExamen",
        //             new
        //             {
        //                 ExamenId = examenId

        //             },
        //            commandType: CommandType.StoredProcedure
        //        );
        //    }
        //}





        //public Examen GetExamenPorId(int examenId)
        //{
        //    using (var conn = ConexionBD.GetConexion())
        //    {
        //        return conn.QuerySingleOrDefault<Examen>(
        //            "sp_GetExamenPorId",
        //            new { ExamenId = examenId },
        //            commandType: CommandType.StoredProcedure
        //        );
        //    }
        //}




        //public List<EstudianteDto> GetEstudiantesPorExamenPorPagina(int estudianteId, int examenid, int cantidadPorPagina, int paginaActual)
        //{
        //    using (var conn = ConexionBD.GetConexion())
        //    {
        //        return conn.Query<EstudianteDto>(
        //            "sp_GetEstudiantesPorExamanPorPagina",
        //            new { EstudianteId = estudianteId, ExamenId = examenid, CantidadPorPagina = cantidadPorPagina, PaginaActual = paginaActual },
        //            commandType: CommandType.StoredProcedure
        //        ).ToList();
        //    }
        //}

        //public void InsertNotaEstudianteExamen(int estudianteId, int examenid, int nota)
        //{
        //    using (var conn = ConexionBD.GetConexion())
        //    {
        //        conn.Execute(
        //           "sp_InsertNotaEstudianteExamen",
        //           new
        //           {
        //               EstudianteId = estudianteId,
        //               ExamenId = examenid,
        //               Nota = nota
        //           },
        //           commandType: CommandType.StoredProcedure
        //       );
        //    }
        //}




    }
}

