using Data.Taller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTaller
{
    public class TallerServices
    {
        public List<AUTO> obtenerAutos()
        {
            TallerDataServices tallerDataService = new TallerDataServices();

            return tallerDataService.obtenerAutos();
        }
        public IList<ESTADO> obtenerEstados()
        {
            TallerDataServices tallerDataService = new TallerDataServices();

            return tallerDataService.obtenerEstados();
        }

        public AutoDto Auto_Detalle(int id)
        {
            TallerDataServices tallerDataService = new TallerDataServices();

             return tallerDataService.Auto_Detalle(id);
        }
        public AutoDto Auto_Detalle(AutoDto oAutoVM)
        {
            TallerDataServices tallerDataService = new TallerDataServices();

            return tallerDataService.Auto_Detalle(oAutoVM);
        }
        public void EliminarAuto(int id)
        {
            TallerDataServices tallerDataService = new TallerDataServices();

           tallerDataService.EliminarAuto(id);
        }
    }
}
