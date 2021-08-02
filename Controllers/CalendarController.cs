using Microsoft.AspNetCore.Mvc;
using Mubco_Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mubco_Proje.Controllers
{
    public class CalendarController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EtkinlikleriGetir()
        {
            var etkinlikler = c.Calendars.ToList();
            return new JsonResult(etkinlikler);
        }

    }
}
