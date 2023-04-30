using CoolEventsExam.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoolEventsExam.Controllers
{
    public class MyTicketsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MyTicketsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string id)
        {

            return View();
        }
    }
}
