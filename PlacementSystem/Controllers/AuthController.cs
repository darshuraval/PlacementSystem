using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using PlacementSystem.Data;
using PlacementSystem.Models;

namespace PlacementSystem.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogger<AuthController> _logger;
        private readonly ApplicationDbContext _context;
        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
                return View();
        }
        public IActionResult Register(Users users)
        {
            if (!ModelState.IsValid)
            {
                return View(users);
            }
            else if(users.Password != users.ConfirmPassword)
            {
                TempData["Error"] = "Passwords do not match.";
                ModelState.AddModelError("", "Passwords do not match.");
                return View(users);
            }
            else if (_context.Users.Any(u => u.Email == users.Email))
            {
                ModelState.AddModelError("", "Email already exists.");
                TempData["Error"] = "Email already exists.";

                return View(users);
            }
            else
            {
                _context.Users.Add(users);
                _context.SaveChanges();
                // Send email verification link to the user
                // SendEmailVerification(users.Email, users.Id);
                TempData["Success"] = "User Register Successfully, Please check your mailbox.";
                return RedirectToAction("Login", "Auth");
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Users users)
        {
            if (!ModelState.IsValid) {
                return View(users);
            }
            var user = _context.Users.FirstOrDefault(u => u.Email == users.Email && u.Password == users.Password);
            if (user == null) {
                ModelState.AddModelError("", "Invalid login attempt.");
                return View(users);
            }
            else
            {
                HttpContext.Session.SetString("UserId", user.Id.ToString());
                HttpContext.Session.SetString("Email", user.Email.ToString());
                HttpContext.Session.SetString("Role", user.Role.ToString());
                TempData["Success"] = "User Logging Successfully";
                return RedirectToAction("Index", user.Role);
            }
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ForgotPassword(Users users)
        {
            if (!ModelState.IsValid) {
                return View(users);
            }
            var user = _context.Users.FirstOrDefault(u => u.Email == users.Email);
            if (user == null) {
                ModelState.AddModelError("", "Email not found.");
                TempData["Error"] = "Send password reset link to the " + users.Email + " email";
                return View(users);
            }
            // Send password reset link to the user's email
            // SendPasswordResetLink(users.Email, users.Id);
            TempData["Success"] = "Send password reset link to the "+users.Email+" email";
            return RedirectToAction("Login", "Auth");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            TempData["Success"] = "User Logout Successfully";
            return RedirectToAction("Index", "Home");
        }
    }
}
