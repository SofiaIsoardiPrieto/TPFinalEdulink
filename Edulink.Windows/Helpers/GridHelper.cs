using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using EduLink.Entidades.Enums;
using System.Windows.Forms;

namespace Edulink.Windows.Helpers
{
    public static class GridHelper
    {
        public static void LimpiarGrilla(DataGridView grilla)
        {
            grilla.Rows.Clear();
        }
        public static DataGridViewRow ConstruirFila(DataGridView grilla)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(grilla);
            return r;
        }
        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case EstudianteDto estudianteDto:
                    r.Cells[0].Value = estudianteDto.Legajo;
                    r.Cells[1].Value = $"{estudianteDto.Apellidos}, {estudianteDto.Nombres}";
                    r.Cells[2].Value = estudianteDto.EstadoEstudiante;
                    r.Cells[3].Value = estudianteDto.FechaAlta.ToString("dd/MM/yyyy");
                    r.Cells[4].Value = estudianteDto.NombreCiudad;
                    r.Cells[5].Value = estudianteDto.Direccion;
                    r.Cells[6].Value = estudianteDto.Telefono;
                    r.Cells[7].Value = estudianteDto.Email;
                    r.Cells[8].Value = estudianteDto.DNI;
                    r.Cells[9].Value = estudianteDto.FechaNacimiento.ToString("dd/MM/yyyy");
                    break;
                case MateriaDto materiaDto:
                    r.Cells[0].Value = materiaDto.NombreMateria;
                    r.Cells[1].Value = materiaDto.AnioCarrera;
                    r.Cells[2].Value = materiaDto.DiasYHorarios;

                    var cell = (DataGridViewCheckBoxCell)r.Cells[3];
                    cell.Value = false; // valor por defecto
                    cell.ReadOnly = !materiaDto.EsLibre; // solo editable si la materia permite libre
                    break;
                case ExamenDto examenDto:
                    r.Cells[0].Value = examenDto.NombreMateria;
                    r.Cells[1].Value = examenDto.FechaExamen.ToString("dd/MM/yyyy");
                    r.Cells[2].Value = examenDto.HoraComienzo.ToString();
                    break;
                case EstudianteExamenDto estudianteExamenDto:
                    r.Cells[0].Value = estudianteExamenDto.Legajo;
                    r.Cells[1].Value = $"{estudianteExamenDto.Apellidos}, {estudianteExamenDto.Nombres}";
                    r.Cells[2].Value = estudianteExamenDto.EstadoExamen==Estado.Pendiente? "-": estudianteExamenDto.Nota.ToString();
                    r.Cells[3].Value = estudianteExamenDto.EstadoExamen.ToString();
                    break;
                case EstudianteMateriaDto estudianteMateriaDto:
                    r.Cells[0].Value = estudianteMateriaDto.Legajo;
                    r.Cells[1].Value = $"{estudianteMateriaDto.Apellidos}, {estudianteMateriaDto.Nombres}";
                    r.Cells[2].Value = estudianteMateriaDto.EstadoMateria == Estado.Pendiente ? "-" : estudianteMateriaDto.Nota.ToString();
                    r.Cells[3].Value = estudianteMateriaDto.EstadoMateria.ToString();
                   
                    break;
                case EstudianteHistorialMateriaDto estudianteHistorialMateriaDto:
                    r.Cells[0].Value = estudianteHistorialMateriaDto.NombreMateria;
                    r.Cells[1].Value = estudianteHistorialMateriaDto.EstadoMateria == Estado.Pendiente ? "-" : estudianteHistorialMateriaDto.Nota.ToString();
                    r.Cells[2].Value = estudianteHistorialMateriaDto.EstadoMateria.ToString();
                  
                    break;
                case Materia materia:
                    r.Cells[0].Value = materia.NombreMateria;
                    break;
                case EstudianteHistorialExamenDto estudianteHistorialExamenDto:
                    r.Cells[0].Value = estudianteHistorialExamenDto.NombreMateria;
                    r.Cells[1].Value = estudianteHistorialExamenDto.Nota;
                    r.Cells[2].Value = estudianteHistorialExamenDto.EstadoExamen;
                    break;
                    //case TipoRango tipoRango:
                    //    r.Cells[0].Value = tipoRango.NombreTipoRango;
                    //    break;
                    //case TipoMedicion tipoMedicion:
                    //    r.Cells[0].Value = tipoMedicion.NombreMedicion;
                    //    break;
                    //case RangoDto rangoDto:
                    //    r.Cells[0].Value = rangoDto.NombreTipoRango;
                    //    r.Cells[1].Value = rangoDto.Rango;
                    //    r.Cells[2].Value = rangoDto.NombreMedicion;
                    //    r.Cells[3].Value = rangoDto.NombrePrueba;
                    //    r.Cells[4].Value = rangoDto.NombreExamen;
                    //    break;
            }
            r.Tag = obj;
        }
        internal static void AgregarFila(DataGridView grilla, DataGridViewRow r)
        {
            grilla.Rows.Add(r);
        }
        public static void QuitarFila(DataGridView grilla, DataGridViewRow r)
        {
            grilla.Rows.Remove(r);
        }
    }
}
