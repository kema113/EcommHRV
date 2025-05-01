using EcommHRV.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommHRV.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var all = await _context.Movies.Include(x => x.Cinema).Include(x => x.Producer).ToListAsync();
            return View(all);
        }
    }
    
}
