using EduLink.Datos.Interfaces;
using EduLink.Datos.Repositorios;
using EduLink.Entidades.Combos;
using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using EduLink.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace EduLink.Servicios.Servicios
{
    public class ServiciosAdministradores : IServiciosAdministradores
    {
        private readonly IRepositorioAdministradores _repositorio;
        public ServiciosAdministradores()
        {
            _repositorio = new RepositorioAdministradores();
        }


        /// <summary>
        /// Valida el inicio de sesion del administrador
        /// </summary>
        /// <param name="codigoAdmin"></param>
        /// <param name="contrasnia"></param>
        /// <returns></returns>
        public int? ValidarInicioSesion(string codigoAdmin, string contrasenia)
        {
            try
            {
                return _repositorio.ValidarInicioSesion(codigoAdmin, contrasenia);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
