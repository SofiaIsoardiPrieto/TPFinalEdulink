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
        /// <summary>
        /// Permite editarla note del estudiante en un examen y su estado (Aprobado, Desaprobado, Ausente)
        /// </summary>
        /// <param name="estudianteExamenDto"></param>
        public void Editar(EstudianteExamenDto estudianteExamenDto)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                conn.Execute(
                    "sp_EditarNotaEstudianteExamen",
                     new
                     {
                         ExamenId = estudianteExamenDto.ExamenId,
                         EstudianteId=estudianteExamenDto.EstudianteId,
                         Nota = estudianteExamenDto.Nota,
                         EstadoExamen = estudianteExamenDto.EstadoExamen.ToString()
                     },
                    commandType: CommandType.StoredProcedure
                );
            }
        }
        /// <summary>
        /// Obtiene la cantidad de estudiantes anotados en un examen específico.
        /// </summary>
        /// <param name="examenId"></param>
        /// <returns></returns>
        public int GetCantidad(int examenId)
        {
            using (var conn = ConexionBD.GetConexion())
            {

                return conn.ExecuteScalar<int>(
                    "sp_GetCantidadEstudiantesExamen",
                    new { ExamenId = examenId },
                    commandType: CommandType.StoredProcedure
                );
            }
        }
        /// <summary>
        /// Pagina los estudiante de un examen especifico.
        /// </summary>
        /// <param name="examenId"></param>
        /// <param name="registrosPorPagina"></param>
        /// <param name="paginaActual"></param>
        /// <returns></returns>
        public List<EstudianteExamenDto> GetEstudiantesExamenPorPagina(int examenId, int registrosPorPagina, int paginaActual)
        {
            //sp_GetEstudiantesExamenPorPagina
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.Query<EstudianteExamenDto>(
                    "sp_GetEstudiantesExamenPorPagina",
                    new { ExamenId = examenId, CantidadPorPagina = registrosPorPagina, PaginaActual = paginaActual },
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

