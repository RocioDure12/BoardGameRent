namespace BoardGameRent.Web.Models
{
    public class Juego
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public decimal PrecioPorDia { get; set; }
        public string ImageUrl { get; set; } = string.Empty;

        // true = en la estantería listo para alquilar; false = ya está alquilado por alguien
        public bool EstaDisponible { get; set; } = true;

        // true = se muestra en el catálogo; false = borrado lógico (archivado)
        public bool Activo { get; set; } = true;
    }
}