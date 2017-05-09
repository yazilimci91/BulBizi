using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bulbizi.Controllers
{
    public class AnasayfaController : Controller
    {
        //
        // GET: /Anasayfa/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Anasayfa()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Icerik()
        {

            return View();
        }

	}
}