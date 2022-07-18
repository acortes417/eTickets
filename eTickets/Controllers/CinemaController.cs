using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppDbContext _contenxt;

        public CinemaController(AppDbContext contenxt)
        {
            _contenxt = contenxt;
        }
        public IActionResult Index()
        {
            var data =  _contenxt.Cinemas.ToList();
            return View(data);
        }
    }
}
