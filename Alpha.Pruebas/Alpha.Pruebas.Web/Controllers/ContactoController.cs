using Alpha.Pruebas.Datos.DA;
using Alpha.Pruebas.Modelo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alpha.Pruebas.Web.Controllers
{
    public class ContactoController : Controller
    {
        //
        // GET: /Contacto/

        public ActionResult Index()
        {
            
            List<Contacto> Contactos= ContactoDA.Seleccionar();
            
            return View(Contactos);
        }

    }
}
