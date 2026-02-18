using EduLink.Datos.Interfaces;
using EduLink.Datos.Repositorios;
using EduLink.Entidades.Combos;
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
        /// Trae las ciudades para el combo
        /// </summary>
        /// <returns></returns>
        public List<CiudadCombo> GetCiudadesCombo()
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
