using Dapper;
using EduLink.Datos.Interfaces;
using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace EduLink.Datos.Repositorios
{
    public class RepositorioEstudiantes : IRepositorioEstudiantes
    {
        private readonly string cadenaConexion;
        public RepositorioEstudiantes()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        /// <summary>
        /// Agrega un estudiante a la base de datos
        /// </summary>
        /// <param name="estudiante"></param>
        public void Agregar(Estudiante estudiante)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = @"INSERT INTO Estudiantes (Legajo, Nombres, Apellidos, Direccion, Telefono, DNI, Email, Contrasenia, FechaNacimiento) 
                        VALUES(@Legajo, @Nombres, @Apellidos, @Direccion, @Telefono, @DNI, @Email, @Contrasenia, @FechaNacimiento); SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(insertQuery, estudiante);
                estudiante.EstudianteId = id;
            }
        }
        /// <summary>
        /// Determina si ya existe un estudiante en la base de datos
        /// </summary>
        /// <param name="estudiante"></param>
        /// <returns></returns>
        public bool Existe(Estudiante estudiante)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (estudiante.EstudianteId == 0)
                {
                    //cuando es nuevo el estudiante y hay que agregar, ver si ya existe.

                    selectQuery = @"SELECT COUNT(*) FROM Estudiantes 
                            WHERE Nombres=@Nombres AND Apellidos=@Apellidos";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, estudiante);
                }
                else
                {
                    //cuando es una edicion y veo si ya existe el estudiante.

                    selectQuery = @"SELECT COUNT(*) FROM Estudiantes 
                           WHERE Nombres=@Nombres AND Apellidos=@Apellidos
                            AND EstudianteId!=@EstudianteId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, estudiante);
                }
            }
            return cantidad > 0;
        }
       
        /// <summary>
        /// Edita un estudiante en la base de datos
        /// </summary>
        /// <param name="estudiante"></param>
        public void Editar(Estudiante estudiante)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string updateQuery = @"UPDATE Estudiantes SET Legajo=@Legajo, Nombres=@Nombres,
                                Apellidos=@Apellidos, Direccion=@Direccion, Telefono=@Telefono, 
                                DNI=@DNI,Email=@Email, Contrasenia=@Contrasenia, FechaNacimiento=@FechaNacimiento                                 
                                WHERE EstudianteId=@EstudianteId";
                conn.Execute(updateQuery, estudiante);
            }
        }
        /// <summary>
        /// Determina si hay un estudiante relacionado con alguna otra tabla
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <returns></returns>
        public bool EstaRelacionado(int estudianteId)
        {
            int cantidad = 0;
            string selectQuery = @"SELECT COUNT(*) FROM Estudiantes WHERE EstudianteId=@estudianteId";
            using (var conn = new SqlConnection(cadenaConexion))
            {
                cantidad = conn.ExecuteScalar<int>(selectQuery);
            }
            return cantidad > 0;
        }
        /// <summary>
        /// Borra un estudiante de la base de datos
        /// </summary>
        /// <param name="estudianteId"></param>
        public void Borrar(int estudianteId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string deleteQuery = "DELETE FROM Estudiantes WHERE EstudianteId=@EstudianteId";
                conn.Execute(deleteQuery, new { estudianteId });
            }
        }
        /// <summary>
        /// Obtiene la cantidad de registros de estudiantes, si se pasa un textoFiltro, 
        /// filtra por apellido que comienze con ese texto
        /// </summary>
        /// <param name="textoFiltro"></param>
        /// <returns></returns>
        public int GetCantidad(string textoFiltro = null)
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (textoFiltro == null)
                {
                    selectQuery = @"SELECT COUNT(*) FROM Estudiantes";
                    cantidad = conn.ExecuteScalar<int>(selectQuery);
                }
                else
                {
                    selectQuery = @"SELECT COUNT(*) FROM Estudiantes  WHERE Apellido LIKE @textoFiltro + '%'";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, new { textoFiltro });
                }
            }
            return cantidad;
        }
        /// <summary>
        /// Devuelve una lista de estudiantes paginada, 
        /// si se pasa un textoFiltro, filtra por apellido que comienze con ese texto
        /// </summary>
        /// <param name="cantidadPorPagina"></param>
        /// <param name="paginaActual"></param>
        /// <param name="textoFiltro"></param>
        /// <returns></returns>
        public List<EstudianteDto> GetEstudiantesPorPagina(int cantidadPorPagina, int paginaActual, string textoFiltro = null)
        {
            List<EstudianteDto> lista = new List<EstudianteDto>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (textoFiltro == null)
                {
                    selectQuery = @" SELECT *
                      FROM vw_EstudiantesConCiudad
                      ORDER BY Apellidos,Nombres
                      OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<EstudianteDto>(selectQuery, new { cantidadRegistros, cantidadPorPagina }).ToList();
                }
                else
                {
                    selectQuery = @"SELECT *
                      FROM vw_EstudiantesConCiudad
                      WHERE Apellido like @textoFiltro + '%'
                      ORDER BY Apellido,Nombre
                      OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<EstudianteDto>(selectQuery, new { cantidadRegistros, cantidadPorPagina, textoFiltro }).ToList();
                }
            }
            return lista;
        }
      
        /// <summary>
        /// Recive una lista de estudiantes para llenar un combo
        /// </summary>
        /// <returns></returns>
        public List<EstudianteCombo> GetEstudiantesCombo()
        {
            List<EstudianteCombo> lista = new List<EstudianteCombo>();

            using (var conn = new SqlConnection(cadenaConexion))
            {

                string selectQuery = @"SELECT EstudianteId, CONCAT(Apellido,', ',Nombre) as NombreCompleto
                            FROM Estudiantes
                            ORDER BY NombreCompleto";
                lista = conn.Query<EstudianteCombo>(selectQuery).ToList();
            }
            return lista;
        }
 
    }
}

