using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OplossingCookiesStorageSessions.ViewModels;

namespace OplossingCookiesStorageSessions.Controllers
{
    public class LocalStorageController : Controller
    {
        [HttpPost]
        public IActionResult Add(LocalStrorageViewModel viewModel)
        {
            // Voeg key-value paar toe aan local storage

            return View("Index");
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Remove(string key)
        {
            // Verwijder key-value paar uit storage op basis van meegegeven string

            return RedirectToAction("Index");
        }
    }
}