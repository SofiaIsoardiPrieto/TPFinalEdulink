using Dapper;
using EduLink.Datos.Helper;
using EduLink.Datos.Interfaces;
using EduLink.Entidades.Combos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace EduLink.Datos.Repositorios
{
    public class RepositorioInscripcionMaterias : IRepositorioInscripcionMaterias
    {

        public RepositorioInscripcionMaterias()
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
        public void Borrar(int estudianteId, int materiaId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                conn.Execute(
                    "sp_BorrarInscripcionMateriaEstudiante",
                    new { EstudianteId = estudianteId, MateriaId = materiaId },
                    commandType: CommandType.StoredProcedure
                );
            }
        }
        public void Agregar(int estudianteId, int materiaId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                conn.Execute(
                    "sp_InscribirMateriaEstudiante",
                    new { EstudianteId = estudianteId, MateriaId = materiaId },
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public void Editar(int estudianteId, int materiaId)
        {
            throw new System.NotImplementedException();
        }



        public int GetCantidad(int estudianteId, int? anioMateria)
        {

            using (var conn = ConexionBD.GetConexion())
            {
                int cantidad = conn.ExecuteScalar<int>(
                    "sp_GetCantidadMateriasPorEstudiante",
                    new { estudianteId = estudianteId, AnioCarrera = anioMateria },
                    commandType: CommandType.StoredProcedure
                );
                return cantidad;
            }
        }

        public List<MateriaDto> GetEstudiantesPorPagina(int estudianteId, int? anioMateria, int registrosPorPagina, int paginaActual)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.Query<MateriaDto>(
                    "sp_GetMateriasPorEstudiantePorPagina",
                    new { EstudianteId = estudianteId, AnioCarrera = anioMateria, CantidadPorPagina = registrosPorPagina, PaginaActual = paginaActual },
                    commandType: CommandType.StoredProcedure
                ).ToList();
            }
        }

        public List<MateriaCombo> GetMateriasCombo(int carreraId)
        {
            using (var conn = ConexionBD.GetConexion())
            {
                return conn.Query<MateriaCombo>(
                    "sp_GetMateriasCombo",
                    new { CarreraId = carreraId, },
                    commandType: CommandType.StoredProcedure
                ).ToList();
            }
        }
    }
}

