using Dapper;
using EduLink.Datos.Helper;
using EduLink.Datos.Interfaces;
using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;

namespace EduLink.Datos.Repositorios
{
    public class RepositorioEstudiantes : IRepositorioEstudiantes
    {

        public RepositorioEstudiantes()
        {

        }
        /// <summary>
        /// Agrega un estudiante a la base de datos
        /// </summary>
        /// <param name="estudiante"></param>
        public void Agregar(Estudiante estudiante)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                int id = conn.QuerySingle<int>(
                    "sp_InsertEstudiante",
                    new // se tuvo que  especificar los campos porque sino Dapper no mapea bien la CarreraId
                    {
                        Legajo = estudiante.Legajo,
                        Nombres = estudiante.Nombres,
                        Apellidos = estudiante.Apellidos,
                        Direccion = estudiante.Direccion,
                        Telefono = estudiante.Telefono,
                        DNI = estudiante.DNI,
                        Email = estudiante.Email,
                        Contrasenia = estudiante.Contrasenia,
                        FechaNacimiento = estudiante.FechaNacimiento, // Error aqui?
                        CiudadId = estudiante.CiudadId,
                        EstadoEstudiante = estudiante.EstadoEstudiante.ToString(),// La bdd no entiende de enums, por eso hay que pasarle un string
                        CarreraId = estudiante.CarreraId,
                        FechaAlta= estudiante.FechaAlta
                    },
                    commandType: CommandType.StoredProcedure
                );

                estudiante.EstudianteId = id; // Para obtener el ID generado y guardarlo en el objeto, por la dudas que se lo necesite
            }
        }
        /// <summary>
        /// Determina si ya existe un estudiante en la base de datos
        /// </summary>
        /// <param name="estudiante"></param>
        /// <returns></returns>
        public bool Existe(Estudiante estudiante)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                int cantidad = conn.ExecuteScalar<int>(
                    "sp_ExisteEstudiante",
                    new { EstudianteId = estudiante.EstudianteId, DNI = estudiante.DNI },
                    commandType: CommandType.StoredProcedure
                );

                return cantidad > 0;
            }
        }
        /// <summary>
        /// Edita un estudiante en la base de datos
        /// </summary>
        /// <param name="estudiante"></param>
        public void Editar(Estudiante estudiante)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                conn.Execute(
                "sp_UpdateEstudiante",
                new
                {
                    EstudianteId = estudiante.EstudianteId,
                    Legajo = estudiante.Legajo,
                    Nombres = estudiante.Nombres,
                    Apellidos = estudiante.Apellidos,
                    Direccion = estudiante.Direccion,
                    Telefono = estudiante.Telefono,
                    DNI = estudiante.DNI,
                    Email = estudiante.Email,
                    Contrasenia = estudiante.Contrasenia,
                    FechaNacimiento = estudiante.FechaNacimiento,
                    CiudadId = estudiante.CiudadId,   
                    CarreraId = estudiante.CarreraId // nuevamente problema de mapeo con dapper y carreraId
                },
                commandType: CommandType.StoredProcedure
                  );
            }
        }
        /// <summary>
        /// Determina si hay un estudiante relacionado con alguna otra tabla
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <returns></returns>
        public bool EstaRelacionado(int estudianteId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                int cantidad = conn.ExecuteScalar<int>(
                    "sp_EstudianteRelacionado",
                    new { EstudianteId = estudianteId },
                    commandType: CommandType.StoredProcedure
                );

                return cantidad > 0;
            }
        }
        /// <summary>
        /// Borra un estudiante de la base de datos
        /// </summary>
        /// <param name="estudianteId"></param>
        public void Borrar(int estudianteId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                conn.Execute(
                    "sp_DeleteEstudiante",
                    new { EstudianteId = estudianteId },
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        /// <summary>
        /// Obtiene la cantidad de registros de estudiantes, si se pasa un textoFiltro, 
        /// filtra por apellido que comienze con ese texto
        /// </summary>
        /// <param name="textoFiltro"></param>
        /// <returns></returns>
        public int GetCantidad(int carreraId, string textoFiltro = null)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                int cantidad = conn.ExecuteScalar<int>(
                    "sp_GetCantidadEstudiantes",
                    new { CarreraId = carreraId, TextoFiltro = textoFiltro },
                    commandType: CommandType.StoredProcedure
                );

                return cantidad;
            }
        }

        /// <summary>
        /// Devuelve una lista de estudiantes paginada, 
        /// si se pasa un textoFiltro, filtra por apellido que comienze con ese texto
        /// </summary>
        /// <param name="cantidadPorPagina"></param>
        /// <param name="paginaActual"></param>
        /// <param name="textoFiltro"></param>
        /// <returns></returns>
        public List<EstudianteDto> GetEstudiantesPorPagina(int carreraId, int cantidadPorPagina, int paginaActual, string textoFiltro = null)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                var lista = conn.Query<EstudianteDto>(
                    "sp_GetEstudiantesPorPagina",
                    new { CantidadPorPagina = cantidadPorPagina, PaginaActual = paginaActual, TextoFiltro = textoFiltro },
                    commandType: CommandType.StoredProcedure
                ).ToList();

                return lista;
            }
        }

        /// <summary>
        /// Recive una lista de estudiantes para llenar un combo
        /// </summary>
        /// <returns></returns>
        public List<EstudianteCombo> GetEstudiantesCombo()
        {
            using (var conn = ConexionBD.GetConexion())
            {
                var lista = conn.Query<EstudianteCombo>(
                    "sp_GetEstudiantesCombo",
                    commandType: CommandType.StoredProcedure
                ).ToList();

                return lista;
            }
        }

        public Estudiante GetEstudiantePorId(int id)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.QuerySingleOrDefault<Estudiante>(
                    "sp_GetEstudiantePorId",
                    new { EstudianteId = id },
                    commandType: CommandType.StoredProcedure
                );
            }
        }
        /// <summary>
        /// Busca estudiantes por DNI
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public EstudianteDto GetEstudiantePorDNI(int dni)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.QuerySingleOrDefault<EstudianteDto>(
                    "sp_GetEstudiantePorDNI",
                    new { DNI = dni },
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public EstudianteDto GetEstudiantePorLegajo(int legajo)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.QuerySingleOrDefault<EstudianteDto>(
                    "sp_GetEstudiantePorLegajo",
                    new { Legajo = legajo },
                    commandType: CommandType.StoredProcedure
                );
            }
        }
    }
}

