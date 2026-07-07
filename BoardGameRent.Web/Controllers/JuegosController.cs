using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BoardGameRent.Web.Data;   
using BoardGameRent.Web.Models;

namespace BoardGameRent.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class JuegosController:ControllerBase
    {
        private readonly BoardGameDbContext _context;

        public JuegosController(BoardGameDbContext context)
        {
            _context = context;
        }


    }
}
