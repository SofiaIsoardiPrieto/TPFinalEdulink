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
    public class ServiciosCiudades : IServiciosCiudades
    {
        private readonly IRepositorioCiudades _repositorio;
        public ServiciosCiudades()
        {
            _repositorio = new RepositorioCiudades();
        }
        /// <summary>
        /// Trae las carreras para el combo segun el administrador logueado
        /// </summary>
        /// <param name="adminId"></param>
        /// <returns></returns>
        public List<Ciudad> GetCiudadesCombo()
        {
            try
            {
                return _repositorio.GetCiudadesCombo();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
