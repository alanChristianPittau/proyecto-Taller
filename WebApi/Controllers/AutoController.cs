using Data.Taller;
using ServicesTaller;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApi.Controllers
{
    public class AutoController : Controller
    {
        public ActionResult obtenerAutos()
        {

            TallerServices tallerServices = new TallerServices();
           List<AUTO> auto = tallerServices.obtenerAutos();
            return View(auto); 
        }
      

    }
}