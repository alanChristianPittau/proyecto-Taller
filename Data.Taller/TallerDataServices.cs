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
        public IList<ESTADO> obtenerEstados()
        {

            using (tallerMecanicoEntities1 db = new tallerMecanicoEntities1())

            {
                List<ESTADO> listaEstados = db.ESTADO.ToList();
                return listaEstados;

            }
        }
        public AutoDto Auto_Detalle(int id)
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
                if (id != 0)
                {
                    oAutoVM.oAuto = db.AUTO.Find(id);
                }
                return oAutoVM;

        }
    }
    public AutoDto Auto_Detalle(AutoDto oAutoVM)
        {

            using (tallerMecanicoEntities1 db = new tallerMecanicoEntities1())

            {
                if (oAutoVM.oAuto.id == 0)
                {
                    db.AUTO.Add(oAutoVM.oAuto);
                }
                else
                {
                    //db.AUTO.Update(oAutoVM.oAuto);
                }
                db.SaveChanges();
                return oAutoVM;

            }
        }
        public void EliminarAuto(int id)
        {
            using (tallerMecanicoEntities1 db = new tallerMecanicoEntities1())

            {
                var oAuto = db.AUTO.FirstOrDefault(x => x.id == id);

                db.AUTO.Remove(oAuto);
                db.SaveChanges();

            }

        }
    }
}
