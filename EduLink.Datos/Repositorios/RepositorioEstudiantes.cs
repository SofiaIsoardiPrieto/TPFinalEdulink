using EduLink.Entidades.Entidades;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using EduLink.Entidades.Combos;
using EduLink.Datos.Interfaces;

namespace EduLink.Datos.Repositorios
{
    public class RepositorioEstudiantes: IRepositorioEstudiantes
    {
        private readonly string cadenaConexion;
        public RepositorioEstudiantes()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
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

        public List<Estudiante> GetEstudiantesPorPagina(int cantidadPorPagina, int paginaActual, string textoFiltro = null)
        {
            List<Estudiante> lista = new List<Estudiante>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (textoFiltro == null)
                {
                    selectQuery = @"SELECT *
                      FROM Estudiantes
                      ORDER BY Apellidos,Nombres
                      OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<Estudiante>(selectQuery, new { cantidadRegistros, cantidadPorPagina }).ToList();
                }
                else
                {
                    selectQuery = @"SELECT *
                      FROM Estudiantes
                      WHERE Apellido like @textoFiltro + '%'
                      ORDER BY Apellido,Nombre
                      OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<Estudiante>(selectQuery, new { cantidadRegistros, cantidadPorPagina, textoFiltro }).ToList();
                }
            }
            return lista;
        }

        public void Borrar(int estudianteId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string deleteQuery = "DELETE FROM Estudiantes WHERE EstudianteId=@EstudianteId";
                conn.Execute(deleteQuery, new { estudianteId });
            }
        }

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

