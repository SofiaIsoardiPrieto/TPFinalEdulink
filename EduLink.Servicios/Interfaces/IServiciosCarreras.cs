using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Servicios.Interfaces
{
    public interface IServiciosCarreras
    {
        List<Carrera> GetCarreraCombo(int? adminId);
        Carrera GetCarreraPorId(int carreraId);
    }
}
