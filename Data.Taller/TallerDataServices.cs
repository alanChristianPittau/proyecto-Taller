using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Mvc;

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

        public void Auto_Detalle(int Id)
        {

            using (tallerMecanicoEntities1 db = new tallerMecanicoEntities1())

            {
                AutoDto oAutoVM = new AutoDto()
                {
                    oAuto = new AUTO(),

                    oListaTecnico = db.TECNICO.Select(tecnico => new SelectListItem()
                    {
                        Text = tecnico.apellido,
                        Value = tecnico.id.ToString()
                    }).ToList(),
                    oListaEstado = db.ESTADO.Select(estado => new SelectListItem()
                    {
                        Text = estado.descripcion,
                        Value = estado.id.ToString()
                    }).ToList()

                };
                if (Id != 0)
                {
                    oAutoVM.oAuto = db.AUTO.Find(Id);
                }

            }
        }
    }
}
