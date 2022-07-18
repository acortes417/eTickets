using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _contenxt;

        public ActorsController(AppDbContext contenxt)
        {
            _contenxt = contenxt;
        }
        //we can change the name
        public IActionResult Index()
        {
            var actors = _contenxt.Actors.ToList();
            return View(actors);
        }
    }
}
