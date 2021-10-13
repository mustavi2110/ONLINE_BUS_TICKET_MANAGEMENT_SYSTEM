using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bus_Ticket_2.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult PaymentProfile()
        {
            return View();
        }
    }
}