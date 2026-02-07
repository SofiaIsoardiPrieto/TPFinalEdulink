using EduLink.Entidades.Combos;
using System.Collections.Generic;

namespace EduLink.Datos.Interfaces
{
    public interface IRepositorioCiudades
    {
        List<CiudadCombo> GetCiudadesCombo();
    }
}

