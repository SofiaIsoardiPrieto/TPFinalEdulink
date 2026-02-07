namespace EduLink.Servicios.Interfaces
{
    public interface IServiciosAdministradores
    {
        int? ValidarInicioSesion(string codigoAdmin, string contrasenia);
    }
}
