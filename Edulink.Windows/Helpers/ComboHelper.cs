using EduLink.Entidades.Entidades;
using EduLink.Servicios.Interfaces;
using EduLink.Servicios.Servicios;
using System.Windows.Forms;

namespace Edulink.Windows.Helpers
{
    public static class ComboHelper
    {
        public static void CargarComboCarreras(ref ComboBox combo, int? adminId)
        {
            IServiciosCarreras serviciosCarreras = new ServiciosCarreras();
            var lista = serviciosCarreras.GetCarreraCombo(adminId);
            var defaultCarrera = new Carrera()
            {
                CarreraId = 0,
                NombreCarrera = "Seleccione Carrera"

            };
            lista.Insert(0, defaultCarrera);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreCarrera";
            combo.ValueMember = "CarreraId";
            combo.SelectedIndex = 0;
        }

        public static void CargarComboCiudades(ref ComboBox combo)
        {
            IServiciosCiudades serviciosCuidadess = new ServiciosCiudades();
            var lista = serviciosCuidadess.GetCiudadesCombo();
            var defaultPaciente = new Ciudad()
            {
                CiudadId = 0,
                NombreCiudad = "Seleccione Ciudad"

            };
            lista.Insert(0, defaultPaciente);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreCiudad";
            combo.ValueMember = "CiudadId";
            combo.SelectedIndex = 0;
        }

        //internal static void CargarComboMedicos(ref ComboBox combo)
        //{
        //    IServiciosMedicos serviciosMedicos = new ServiciosMedicos();
        //    var lista = serviciosMedicos.GetMedicosCombo();
        //    var defaultMedico = new MedicoCombo()
        //    {
        //        MedicoId = 0,
        //        NombreMedico = "Seleccione Medico"

        //    };
        //    lista.Insert(0, defaultMedico);
        //    combo.DataSource = lista;
        //    combo.DisplayMember = "NombreMedico";
        //    combo.ValueMember = "MedicoId";
        //    combo.SelectedIndex = 0;
        //}

        //internal static void CargarComboTipoRangos(ref ComboBox combo)
        //{
        //    IServiciosTipoRangos serviciosTiposRangos = new ServiciosTipoRangos();
        //    var lista = serviciosTiposRangos.GetTiposRangosCombo();
        //    var defaultTiposRangos = new TipoRangoCombo()
        //    {
        //        TipoRangoId = 0,
        //        NombreTipoRango = "Seleccione Tipo de Rango"

        //    };
        //    lista.Insert(0, defaultTiposRangos);
        //    combo.DataSource = lista;
        //    combo.DisplayMember = "NombreTipoRango";
        //    combo.ValueMember = "TipoRangoId";
        //    combo.SelectedIndex = 0;
        //}

        //internal static void CargarComboExamenes(ref ComboBox combo)
        //{
        //    IServiciosExamenes serviciosExamenes = new ServiciosExamenes();
        //    var lista = serviciosExamenes.GetExamenesCombo();
        //    var defaultExamen = new ExamenCombo()
        //    {
        //        ExamenId = 0,
        //        NombreExamen = "Seleccione Examen"

        //    };
        //    lista.Insert(0, defaultExamen);
        //    combo.DataSource = lista;
        //    combo.DisplayMember = "NombreExamen";
        //    combo.ValueMember = "ExamenId";
        //    combo.SelectedIndex = 0;
        //}
    }
}