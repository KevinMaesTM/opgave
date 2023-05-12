using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OplossingCookiesStorageSessions.ViewModels;

namespace OplossingCookiesStorageSessions.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult CreateSession()
        {
            var viewModel = new SessionViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult CreateSession(SessionViewModel viewModel)
        {
            // Maak een nieuwe sessie aan

            return RedirectToAction("Index");
        }

        public IActionResult DeleteSession()
        {
            // Verwijder de sessie

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var viewModel = new SessionViewModel
            {
                // Toon sesiondata
            };

            return View(viewModel);
        }
    }
}