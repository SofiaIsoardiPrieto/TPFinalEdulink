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
    public class RepositorioEstudiantesMaterias : IRepositorioEstudiantesMaterias
    {

        public RepositorioEstudiantesMaterias()
        {

        }
        public bool Existe(int estudianteId, int materiaId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                int cantidad = conn.ExecuteScalar<int>(
                    "sp_ExisteInscripcionMateria",
                    new { EstudianteId = estudianteId, MateriaId = materiaId },
                    commandType: CommandType.StoredProcedure
                );

                return cantidad > 0;
            }
        }

        public void Agregar(int estudianteId, int materiaId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                conn.Execute(
                    "sp_InscribirMateriaEstudiante",
                    new { EstudianteId = estudianteId,  MateriaId = materiaId },
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public void Editar(int estudianteId, int materiaId)
        {
            throw new System.NotImplementedException();
        }

       

        public int GetCantidad(int estudianteId, int anioMateria, bool inscripto)
        {
           
            using (var conn = ConexionBD.GetConexion())
            {

                return conn.ExecuteScalar<int>(
                    "sp_GetCantidadMateriasPorEstudiante",
                    new { estudianteId=estudianteId , AnioCarrera = anioMateria , Inscripto=inscripto },
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public List<MateriaDto> GetEstudiantesPorPagina(int estudianteId, int anioMateria, bool inscripto, int registrosPorPagina, int paginaActual)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.Query<MateriaDto>(
                    "sp_GetMateriasPorEstudiantePorPagina",
                    new { EstudianteId = estudianteId, AnioCarrera = anioMateria, Inscripto = inscripto, CantidadPorPagina = registrosPorPagina, PaginaActual = paginaActual },
                    commandType: CommandType.StoredProcedure
                ).ToList();
            }
        }

        

    }
}

