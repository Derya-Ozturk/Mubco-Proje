using Microsoft.AspNetCore.Mvc;
using Mubco_Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;


namespace Mubco_Proje.Controllers
{

    public class MapController : Controller
    {
        Context c = new Context();
                
        public IActionResult Index()
        {
            return View(new Map());
        }       
        public IActionResult Location(Map location)
        {
            c.Maps.Add(location);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
