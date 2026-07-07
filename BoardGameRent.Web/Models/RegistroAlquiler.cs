using BoardGameRent.Web.Enums;
using System;

namespace BoardGameRent.Web.Models
{
    public class RegistroAlquiler
    {
        public int Id { get; set; }

        // Vinculación con la entidad Usuario (Clave Foránea)
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;

        // Vinculación con la entidad Juego (Clave Foránea)
        public int JuegoId { get; set; }
        public Juego Juego { get; set; } = null!;

        // Datos específicos de esta transacción
        public DateTime FechaAlquiler { get; set; } = DateTime.Now;
        public DuracionAlquiler Duracion { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public decimal PrecioFinal { get; set; }
        public EstadoAlquiler Estado { get; set; } = EstadoAlquiler.Activo;
    }
}