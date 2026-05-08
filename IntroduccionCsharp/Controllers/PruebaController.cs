using IntroduccionCsharp.Services;
using System;
using IntroduccionCsharp.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroduccionCsharp.Models;

namespace IntroduccionCsharp.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suma()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Suma(String x, String y, String r1)
        {
            int res = Convert.ToInt16(x) + Convert.ToInt16(y);
            ViewBag.res=Convert.ToString(res);
            return View();
        }
        public ActionResult Calculos(OperaBas op)
        {
            op.Suma();
            return View(op);
        }
        public ActionResult MuestraPelidulas()
        {
            var peluculasService = new PeliculasServices();
            var model = peluculasService.ObtenerPeliculas();

            return View(model);
        }
    }
}