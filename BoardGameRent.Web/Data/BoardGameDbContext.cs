using Microsoft.EntityFrameworkCore;
using BoardGameRent.Web.Models;
using BoardGameRent.Web.Enums;

namespace BoardGameRent.Web.Data
{
    public class BoardGameDbContext:DbContext
    {
        public BoardGameDbContext(DbContextOptions<BoardGameDbContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Juego> Juegos { get; set; }
        public DbSet<RegistroAlquiler> RegistrosAlquiler{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Juego>().HasData(
                new Juego { Id = 1, Nombre = "Catan",Activo=true, Descripcion="enjoy your game", ImageUrl="https://devirinvestments.s3.eu-west-1.amazonaws.com/img/catalog/product/8436017220100-1200-face3d.jpg",EstaDisponible=true,PrecioPorDia=3000},
                new Juego { Id = 2, Nombre = "Dixit",Activo=true, Descripcion= "enjoy your game", ImageUrl= "https://acdn-us.mitiendanube.com/stores/001/750/716/products/dixit_01-755cf40946eda097de17097563234968-640-0.webp",EstaDisponible = true,PrecioPorDia =1000},
                new Juego { Id = 3, Nombre = "Carcassonne",Activo=true,Descripcion = "enjoy your game", ImageUrl= "https://acdn-us.mitiendanube.com/stores/001/029/049/products/cajitas-elegidas-parte-7-63-716b6f763d3bdfd50017516475086918-640-0.webp",EstaDisponible =true,PrecioPorDia =1000}

                
            );

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    Id = 1,
                    NombreCompleto = "Melody Luz",
                    Apellido = "Cacas",
                    Dni = "43023456",
                    Email = "rocioevelyndure@gmail.com",
                    Rol = RolUsuario.Administrador,
                    Telefono = "4234567",

                },

                new Usuario
                {
                    Id = 2,
                    NombreCompleto = "Evelyn",
                    Apellido = "Dure",
                    Dni = "43023456",
                    Email = "rooci_16@hotmail.com.ar",
                    Rol = RolUsuario.Cliente,
                    Telefono = "4234568",

                },
                new Usuario
                {
                    Id = 3,
                    NombreCompleto = "Rocio",
                    Apellido = "Evelyn",
                    Dni = "43023456",
                    Email = "taskplannerapplication@gmail.com",
                    Rol = RolUsuario.Cajero,
                    Telefono = "4234569",

                }

            );

        }

    }

}
