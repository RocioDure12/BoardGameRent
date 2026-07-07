using BoardGameRent.Web.Enums;

namespace BoardGameRent.Web.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? NombreCompleto { get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; } 
        public string Telefono { get; set; } = string.Empty;
        public string Dni { get; set; } = string.Empty;
        public RolUsuario Rol { get; set; } = RolUsuario.Cliente;
    }
}
