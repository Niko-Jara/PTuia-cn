using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProjectFenix.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Colaborador()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult EPlanillas()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Telefono()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Correo()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Salario()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Vacaciones()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Aguinaldo()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Preavisos()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Cesantias()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult HorasExtra()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Feriados()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Usuarios()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}