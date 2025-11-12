using EduLink.Entidades.Dtos;
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
                    r.Cells[3].Value = estudianteDto.Ciudad;
                    r.Cells[4].Value = estudianteDto.Direccion;
                    r.Cells[5].Value = estudianteDto.Telefono;
                    r.Cells[6].Value = estudianteDto.Email;
                    r.Cells[7].Value = estudianteDto.DNI;
                    r.Cells[8].Value = $"{estudianteDto.FechaNacimiento.Day}/{estudianteDto.FechaNacimiento.Month}/{estudianteDto.FechaNacimiento.Year}";
                    break;
                    //case ResultadoDto resultadoDto:
                    //    r.Cells[0].Value = resultadoDto.NombrePrueba;
                    //    r.Cells[1].Value = resultadoDto.ResultadoPrueba;
                    //    r.Cells[2].Value = resultadoDto.NombreRango;
                    //    break;
                    //case ExamenDto examen:
                    //    r.Cells[0].Value = examen.NombreExamen;
                    //    r.Cells[1].Value = examen.NombrePrueba;
                    //    r.Cells[2].Value = examen.Rango;
                    //    r.Cells[3].Value = examen.NombreTipoRango;
                    //    break;
                    //case Protocolo protocolo:
                    //    r.Cells[0].Value = protocolo.NombrePaciente;
                    //    r.Cells[1].Value = $"{protocolo.FechaRealizacion.Day}/{protocolo.FechaRealizacion.Month}/{protocolo.FechaRealizacion.Year}";
                    //    r.Cells[2].Value = protocolo.NombreMedico;
                    //    break;
                    //case PruebaCombo prueba:
                    //    r.Cells[0].Value = prueba.NombrePrueba;
                    //    break;
                    //case PruebaDto pruebaDto:
                    //    r.Cells[0].Value = pruebaDto.NombrePrueba;
                    //    r.Cells[1].Value = pruebaDto.Rango;
                    //    r.Cells[2].Value = pruebaDto.NombreMedicion;
                    //    r.Cells[3].Value = pruebaDto.NombreTipoRango;
                    //    break;
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
