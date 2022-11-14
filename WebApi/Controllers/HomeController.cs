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

        [HttpGet]
        public ActionResult Auto_Detalle(int id)
        {
            AutoDto oAutoVM = new AutoDto();
         
            TallerServices tallerServices = new TallerServices();
            var Estados = tallerServices.obtenerEstados();
            ViewBag.transicionesValidas = Estados;
            oAutoVM = tallerServices.Auto_Detalle(id);
            return View(oAutoVM);

        }
        [HttpPost]
        public ActionResult Auto_Detalle(AutoDto oAutoVM)
        {

            //IEnumerable<TransicionDTO> transicionesValidas = wfService.transicionesValidas(s, usuario);
            TallerServices tallerServices = new TallerServices();
          
            oAutoVM = tallerServices.Auto_Detalle(oAutoVM);
            return RedirectToAction("Index", "Home");

        }

        [HttpGet]

        public ActionResult Eliminar(int Id)
        {
            AutoDto oAutoVM = new AutoDto();

            TallerServices tallerServices = new TallerServices();
            tallerServices.EliminarAuto(Id);
            return RedirectToAction("Index", "Home");
        }
    }
}
