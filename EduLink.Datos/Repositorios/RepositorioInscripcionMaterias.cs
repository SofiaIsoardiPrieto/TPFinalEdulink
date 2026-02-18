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
        /// <summary>
        /// Verifica si el estudiante ya está inscrito en la materia. 
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <param name="materiaId"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Borra la inscrpcion de un estudiante en una materia.
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <param name="materiaId"></param>
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
        /// <summary>
        /// Incribe un estudiante a una materia.
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <param name="materiaId"></param>
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

        /// <summary>
        /// Obtiene la cantidad de materias a las que un estudiante se puede inscribir.
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <param name="anioMateria"></param>
        /// <returns></returns>

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
        /// <summary>
        /// Pagina las materias a las que un estudiante se puede inscribir.
        /// </summary>
        /// <param name="estudianteId"></param>
        /// <param name="anioMateria"></param>
        /// <param name="registrosPorPagina"></param>
        /// <param name="paginaActual"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Trae las materias para el combobox.
        /// </summary>
        /// <param name="carreraId"></param>
        /// <returns></returns>
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

