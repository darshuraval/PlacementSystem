using Microsoft.AspNetCore.Mvc;

namespace PlacementSystem.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
