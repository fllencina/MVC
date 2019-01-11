using Alpha.Pruebas.Modelo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.Pruebas.Datos.DA
{
    public static class ContactoDA
    {

        public static List<Contacto> Seleccionar(string Nombre=null)
        {
            using(PruebasContext db=new PruebasContext()){
                 return db.Contactos.Where(C =>
                                                (Nombre == null || C.Nombre.Trim().ToUpper().Contains(Nombre.Trim().ToUpper()))
                                          )
                                    .ToList();
            }
        }

        public static int Insertar(Contacto Contacto)
        {
            using(PruebasContext db=new PruebasContext())
            {
                db.Contactos.Add(Contacto);
                db.SaveChanges();
                return Contacto.ID;
            }
        }

        public static void Eliminar(Contacto Contacto)
        {
            using(PruebasContext db=new PruebasContext())
            {
                
            }
        }


    }
}
