using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.greetings = (hour < 12) ? "Good Morning" : "Good Afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
             // TODO: Email guestResponse to the part organizer 
            if(ModelState.IsValid)
            {
                // TODO: Email guestResponse to the part organizer 
                return View("Thanks",guestResponse);
            }
            else
            {
                // there is a validation error - redisplay the form 
                return View();
            }
            
        }

    }
}
