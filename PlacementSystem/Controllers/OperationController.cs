using Microsoft.AspNetCore.Mvc;
using PlacementSystem.Data;
using PlacementSystem.Models;

namespace PlacementSystem.Controllers
{
    public class OperationController : Controller
    {
        ApplicationDbContext _context;
        public OperationController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult Cma()
        //{
        //}
    }
}
