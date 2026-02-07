using EduLink.Datos.Interfaces;
using EduLink.Datos.Repositorios;
using EduLink.Entidades.Combos;
using EduLink.Entidades.Entidades;
using EduLink.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace EduLink.Servicios.Servicios
{
    public class ServiciosCarreras : IServiciosCarreras
    {
        private readonly IRepositorioCarreras _repositorio;
        public ServiciosCarreras()
        {
            _repositorio = new RepositorioCarreras();
        }
        /// <summary>
        /// Trae las carreras para el combo segun el administrador logueado
        /// </summary>
        /// <param name="adminId"></param>
        /// <returns></returns>
        public List<CarreraCombo> GetCarreraCombo(int? adminId)
        {
            try
            {
                return _repositorio.GetCarreraCombo(adminId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Obtiene la carrera por Id
        /// </summary>
        /// <param name="carreraId"></param>
        /// <returns></returns>

        public Carrera GetCarreraPorId(int carreraId)
        {
            try
            {
                return _repositorio.GetCarreraPorId(carreraId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
