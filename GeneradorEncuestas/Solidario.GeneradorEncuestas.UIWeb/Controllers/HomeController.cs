using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Solidario.GeneradorEncuestas.UIWeb.WSFormularios;

namespace Solidario.GeneradorEncuestas.UIWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Formulario()
        {
            DtoFormulario formulario = new DtoFormulario();
            using (var cli = new FormulariosSoapClient())
            {
                formulario = cli.GetFormularioPorCodigo("F001");
            }
            return View(formulario);
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}