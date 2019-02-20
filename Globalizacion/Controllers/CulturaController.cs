using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using System.Globalization;
using Globalizacion.Models;

namespace Globalizacion.Controllers
{
    public class CulturaController : Controller
    {
        // GET: Cultura
        public ActionResult Index(String cultura)
        {
            if (cultura is null)
            {
                cultura = Thread.CurrentThread.CurrentUICulture.ToString();
            }
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultura);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(cultura);
            ViewBag.Fecha = DateTime.Today.ToLongDateString().ToString(Thread.CurrentThread.CurrentCulture);
            return View();
        }

        // POST: Cultura
        [HttpPost]
        public ActionResult Index(String cultura, Cliente cliente)
        {
            if (cultura is null)
            {
                cultura = Thread.CurrentThread.CurrentUICulture.ToString();
            }
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultura);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(cultura);
            ViewBag.Agradecimiento = Resources.Cultura.Agradecimiento+" "+cliente.Nombre;
            ViewBag.Donacion = String.Format(Thread.CurrentThread.CurrentUICulture, "{0:C}", cliente.Contribucion);
            return View(cliente);
        }

    }

}