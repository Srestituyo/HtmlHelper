using HtmlHelperTr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelperTr.Controllers
{
    public class FormularioController : Controller
    {
        // GET: Formulario
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index( Formulario formulario)
        {
            if (ModelState.IsValid)
            {
                
                return View("Detalle", formulario);
            }
            else {
                return View(formulario);
            }

            
        }

        public ActionResult Detalle() {
            return View();
        }
    }
}
