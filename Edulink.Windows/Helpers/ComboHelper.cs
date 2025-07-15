using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EduLink.Entidades.Combos.EstudianteCombo;

namespace Edulink.Windows.Helpers
{
    //public static void CargarComboPruebas(ref ComboBox combo, int? examenId)
    //{
    //    IServiciosPruebas serviciosPruebas = new ServiciosPruebas();
    //    var lista = serviciosPruebas.GetPruebaCombo(examenId);
    //    var defaultPrueba = new PruebaCombo()
    //    {
    //        PruebaId = 0,
    //        NombrePrueba = "Seleccione Prueba"

    //    };
    //    lista.Insert(0, defaultPrueba);
    //    combo.DataSource = lista;
    //    combo.DisplayMember = "NombrePrueba";
    //    combo.ValueMember = "PruebaId";
    //    combo.SelectedIndex = 0;
    //}

    //public static void CargarComboPacientes(ref ComboBox combo)
    //{
    //    IServiciosPacientes serviciosPacientes = new ServiciosPacientes();
    //    var lista = serviciosPacientes.GetPacientesCombo();
    //    var defaultPaciente = new PacienteCombo()
    //    {
    //        PacienteId = 0,
    //        NombreCompleto = "Seleccione Paciente"

    //    };
    //    lista.Insert(0, defaultPaciente);
    //    combo.DataSource = lista;
    //    combo.DisplayMember = "NombreCompleto";
    //    combo.ValueMember = "PacienteId";
    //    combo.SelectedIndex = 0;
    //}

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
