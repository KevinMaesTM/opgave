using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OplossingCookiesStorageSessions.ViewModels;
using System;

namespace OplossingCookiesStorageSessions.Controllers
{
    public class CookieController : Controller
    {
        [HttpPost]
        public IActionResult DeleteCookie()
        {
            // Verwijder de cookie

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            if (Request.Cookies["MyCookie"] != null)
            {
                // Haal cookie data op

                return View();
            }
            return View();
        }

        [HttpPost]
        public IActionResult SetCookie(string username)
        {
            // Maak een nieuwe cookie aan & geef een waarde

            return RedirectToAction("Index");
        }
    }
}