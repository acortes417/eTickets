using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _contenxt;

        public ProducersController(AppDbContext contenxt)
        {
            _contenxt = contenxt;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _contenxt.Producer.ToListAsync();
            return View(allProducers);
        }
    }
}
