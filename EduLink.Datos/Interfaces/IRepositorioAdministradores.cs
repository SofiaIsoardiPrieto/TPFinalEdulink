namespace EduLink.Datos.Interfaces
{
    public interface IRepositorioAdministradores
    {
        int? ValidarInicioSesion(string codigoAdmin, string contrasenia);
    }
}

