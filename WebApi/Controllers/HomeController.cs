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
        [HttpGet]

        public ActionResult Index()
        {

            TallerServices tallerServices = new TallerServices();
            List<AUTO> auto = tallerServices.obtenerAutos();
            return View(auto);
        }

        [HttpPost]

        public ActionResult Auto_Detalle(int Id)
        {
            TallerServices tallerServices = new TallerServices();
            tallerServices.Auto_Detalle(Id);
            return View();

        }

        [HttpGet]

        public ActionResult Eliminar(int Id)
        {
            TallerServices tallerServices = new TallerServices();
            tallerServices.Auto_Detalle(Id);
            return View();

        }
    }
}
