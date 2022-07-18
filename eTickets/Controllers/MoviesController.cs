using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _contenxt;

        public MoviesController(AppDbContext contenxt)
        {
            _contenxt = contenxt;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _contenxt.Movie.ToListAsync();
            return View(allProducers);
        }
    }
}
