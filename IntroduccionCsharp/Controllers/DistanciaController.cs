using IntroduccionCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionCsharp.Controllers
{
    public class DistanciaController : Controller
    {
        public ActionResult Distancia()
        {
            return View(new DistanciaPuntos());
        }

        [HttpPost]
        public ActionResult Distancia(DistanciaPuntos dp)
        {
            dp.CalcularDistancia();
            return View(dp);
        }
    }
}