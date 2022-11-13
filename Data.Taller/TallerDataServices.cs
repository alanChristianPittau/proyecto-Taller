using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;



namespace Data.Taller
{
    public class TallerDataServices
    {
        private tallerMecanicoEntities1 Context = new tallerMecanicoEntities1();

        public List<AUTO> obtenerAutos()
        {

            using (tallerMecanicoEntities1 db = new tallerMecanicoEntities1())

            {
                List<AUTO> lista = db.AUTO.Include("ESTADO").Include("TECNICO").ToList();
                return lista;
               
            }
        }
    }
}
