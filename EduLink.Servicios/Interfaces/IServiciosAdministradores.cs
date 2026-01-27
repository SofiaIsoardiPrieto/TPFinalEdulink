using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Servicios.Interfaces
{
    public interface IServiciosAdministradores
    {
        int? ValidarInicioSesion(string codigoAdmin, string contrasenia);
    }
}
