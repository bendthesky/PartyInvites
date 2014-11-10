using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int Hour = DateTime.Now.Hour;
            ViewBag.Pingas = Hour < 12 ? "PINGAS" : "Pingas";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse response)
        {
            if (ModelState.IsValid)
            {
                //TODO: Email response to party organizer
                return View("Thanks", response);
            }
            else
            {
                return View();
            }
        }
    }
}