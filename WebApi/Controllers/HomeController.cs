using Data.Taller;
using ServicesTaller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            TallerServices tallerServices = new TallerServices();
            List<AUTO> auto = tallerServices.obtenerAutos();
            return View(auto);
        }
    }
}
