using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using System.Collections.Generic;

namespace EduLink.Datos.Interfaces
{
    public interface IRepositorioAdministradores
    {
        int? ValidarInicioSesion(string codigoAdmin, string contrasenia);
    }
}

