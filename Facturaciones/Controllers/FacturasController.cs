using Facturaciones.DAL;
using Facturaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Facturaciones.Controllers
{
    public class FacturasController : Controller
    {
        FacturasRepository repo = new FacturasRepository();
        // GET: Facturas
        public ActionResult Index()
        {
            IEnumerable<Facturas> lista=  repo.GetFacturasPorPrestador("Alan Masriera");
            return View(lista);
        }

        // GET: Facturas/Details/5

    }
}
