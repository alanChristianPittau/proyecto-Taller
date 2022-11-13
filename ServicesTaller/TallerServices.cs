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

        public void  Auto_Detalle(int id)
        {
            TallerDataServices tallerDataService = new TallerDataServices();

             tallerDataService.Auto_Detalle(id);
        }
    }
}
