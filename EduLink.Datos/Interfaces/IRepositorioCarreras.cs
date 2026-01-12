using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Datos.Interfaces
{
    public interface IRepositorioCarreras
    {
        List<Carrera> GetCarreraCombo(int? adminId);
    }
}

