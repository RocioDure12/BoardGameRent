using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BoardGameRent.Web.Data;       
using BoardGameRent.Web.Models;       

namespace BoardGameRent.Web.Controllers
{

    public class JuegosController:Controller
    {
        private readonly BoardGameDbContext _context;

        public JuegosController(BoardGameDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> ListaJuegos([FromQuery] int page = 1, [FromQuery] int limit = 10)
        { 
            // 1. Evitar páginas inválidas
            if (page < 1) page = 1;

            // 2. Calcular cuántos registros saltar
            int registrosASaltar = (page - 1) * limit;

            // 3. Traer solo los juegos de esta página
            var listaJuegos = await _context.Juegos
                                        .Skip(registrosASaltar)
                                        .Take(limit)
                                        .ToListAsync();

            // 4. Calcular los datos para la vista (mochila ViewBag)
            var totalJuegos = await _context.Juegos.CountAsync();
            ViewBag.PaginaActual = page;
            ViewBag.TotalPaginas = (int)Math.Ceiling((double)totalJuegos / limit);

            return View(listaJuegos);
        }

        [HttpGet]
        public async Task<IActionResult> DetalleJuego(int id)
        {
            var juego = await _context.Juegos.FirstOrDefaultAsync(j => j.Id == id);
            if (juego == null)
            {
                return NotFound();
            }
            return View(juego);
        }

        [HttpGet]
        public async Task<IActionResult> CrearJuego()
        {
            return View("Formulario", new Juego());
        }

        [HttpPost]
        public async Task<IActionResult> CrearJuego(Juego nuevoJuego)
        {
            if (ModelState.IsValid)
            {
                _context.Juegos.Add(nuevoJuego);
                await _context.SaveChangesAsync();
                return RedirectToAction("ListaJuegos");
            }
            return View("Formulario", nuevoJuego);

        }

        [HttpGet]
        public async Task<IActionResult> EditarJuego(int id)
        {
            var juego = await _context.Juegos.FindAsync(id);
            if (juego == null)
            {
                return NotFound();
            }
            return View("Formulario",juego);
        }

        [HttpPost]
        public async Task<IActionResult> EditarJuego(Juego juego)
        {
            if (ModelState.IsValid)
            {
                _context.Juegos.Update(juego);
                await _context.SaveChangesAsync();
                return RedirectToAction("ListaJuegos");
            }
            return View("Formulario", juego);
        }









    }

}
