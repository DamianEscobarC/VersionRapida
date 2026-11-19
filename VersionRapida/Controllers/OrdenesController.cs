using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechFixPro.Data;

namespace TechFixPro.Controllers
{
    public class OrdenesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public OrdenesController(ApplicationDbContext context) => _context = context;

        public async Task<IActionResult> Index()
        {
            var lista = await _context.OrdenesServicio
                .Include(o => o.Categoria)
                .Include(o => o.Tecnico)
                .ToListAsync();
            return View(lista);
        }
    }
}