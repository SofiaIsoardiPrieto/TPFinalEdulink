using Dapper;
using EduLink.Datos.Helper;
using EduLink.Datos.Interfaces;
using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
                    new
                    {
                        estudiante.Legajo,
                        estudiante.Nombres,
                        estudiante.Apellidos,
                        estudiante.Direccion,
                        estudiante.Telefono,
                        estudiante.DNI,
                        estudiante.Email,
                        estudiante.Contrasenia,
                        estudiante.FechaNacimiento,
                        estudiante.CiudadId,
                        EstadoEstudiante = estudiante.EstadoEstudiante.ToString(),
                        estudiante.CarreraId,
                        estudiante.FechaAlta

                    },
                    commandType: CommandType.StoredProcedure
                );

                estudiante.EstudianteId = id;

                InscribirEstudianteNuevoMaterias(id, estudiante.CarreraId);

            }
        }

        private void InscribirEstudianteNuevoMaterias(int id, int carreraId)
        {
            //Inscribir automáticamente en materias de primer año
            using (var conn = ConexionBD.GetConexion())
            {
                conn.Execute(
                "sp_InscribirMateriasPrimerAnio",
                new { EstudianteId = id, CarreraId = carreraId },
                commandType: CommandType.StoredProcedure
            );
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
                    EstadoEstudiante = estudiante.EstadoEstudiante.ToString(),
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
        /// Obtiene la cantidad de registros de estudiantes, si se pasa un filtro, 
        /// filtra por el mismo.
        /// </summary>
        /// <param name="textoFiltro"></param>
        /// <returns></returns>
        public int GetCantidad(int carreraId, int? edadMin = null, int? edadMax = null, int? anioAlta = null, int? ciudadId = null, string estado = null)
        {
            if (string.IsNullOrWhiteSpace(estado)) estado = null;
            using (var conn = ConexionBD.GetConexion())
            {

                return conn.ExecuteScalar<int>(
                    "sp_GetCantidadEstudiantes",
                    new { CarreraId = carreraId, EdadMin = edadMin, EdadMax = edadMax, AnioAlta = anioAlta, CiudadId = ciudadId, Estado = estado },
                    commandType: CommandType.StoredProcedure
                );
            }
        }
        /// <summary>
        /// Pagina los estudiantes
        /// </summary>
        /// <param name="carreraId"></param>
        /// <param name="cantidadPorPagina"></param>
        /// <param name="paginaActual"></param>
        /// <param name="edadMin"></param>
        /// <param name="edadMax"></param>
        /// <param name="anioAlta"></param>
        /// <param name="ciudadId"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public List<EstudianteDto> GetEstudiantesPorPagina(int carreraId, int cantidadPorPagina, int paginaActual, int? edadMin = null, int? edadMax = null, int? anioAlta = null, int? ciudadId = null, string estado = null)
        {
            if (string.IsNullOrWhiteSpace(estado)) estado = null;
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.Query<EstudianteDto>(
                    "sp_GetEstudiantesPorPagina",
                    new { CarreraId = carreraId, CantidadPorPagina = cantidadPorPagina, PaginaActual = paginaActual, EdadMin = edadMin, EdadMax = edadMax, AnioAlta = anioAlta, CiudadId = ciudadId, Estado = estado },
                    commandType: CommandType.StoredProcedure
                ).ToList();
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

