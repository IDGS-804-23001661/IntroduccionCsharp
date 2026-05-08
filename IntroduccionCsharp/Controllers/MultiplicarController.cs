using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroduccionCsharp.Models;

namespace IntroduccionCsharp.Controllers
{
    public class MultiplicarController : Controller
    {
        public ActionResult Index()
        {
            return View(new MultiplicacionSuma());
        }

        [HttpPost]
        public ActionResult Index(MultiplicacionSuma ms)
        {
            ms.Multiplicar();
            return View(ms);
        }
    }
}