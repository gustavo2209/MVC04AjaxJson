using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC04AjaxJson.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult Demo01()
        {
            Telefonos t = new Telefonos();
            t.numero = "999627956";
            t.costo = 700;
            t.activo = true;

            return Json(t, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Demo02()
        {
            Telefonos t1 = new Telefonos();
            Telefonos t2 = new Telefonos();
            Telefonos t3 = new Telefonos();

            t1.numero = "999627956";
            t1.costo = 700;
            t1.activo = true;

            t2.numero = "988627956";
            t2.costo = 800;
            t2.activo = true;

            t3.numero = "785627956";
            t3.costo = 750;
            t3.activo = false;

            List<Telefonos> list = new List<Telefonos>();
            list.Add(t1);
            list.Add(t2);
            list.Add(t3);

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Demo03()
        {
            Telefonos t1 = new Telefonos();
            Telefonos t2 = new Telefonos();
            Telefonos t3 = new Telefonos();

            t1.numero = "999627956";
            t1.costo = 700;
            t1.activo = true;

            t2.numero = "988627956";
            t2.costo = 800;
            t2.activo = true;

            t3.numero = "785627956";
            t3.costo = 750;
            t3.activo = false;

            Clientes cliente = new Clientes();
            cliente.nombre = "Alicia Neruda";
            cliente.telefonos = new Telefonos[] { t1, t2, t3 };

            return Json(cliente, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Demo04()
        {
            Telefonos t1 = new Telefonos();
            Telefonos t2 = new Telefonos();
            Telefonos t3 = new Telefonos();
            Telefonos t4 = new Telefonos();
            Telefonos t5 = new Telefonos();
            Telefonos t6 = new Telefonos();

            t1.numero = "999627956";
            t1.costo = 700;
            t1.activo = true;

            t2.numero = "988627956";
            t2.costo = 800;
            t2.activo = true;

            t3.numero = "785627956";
            t3.costo = 750;
            t3.activo = false;

            t4.numero = "111111111";
            t4.costo = 1000;
            t4.activo = false;

            t5.numero = "222222222";
            t5.costo = 750;
            t5.activo = true;

            t6.numero = "333333333";
            t6.costo = 1200;
            t6.activo = true;

            Clientes cliente1 = new Clientes();
            cliente1.nombre = "Alicia Neruda";
            cliente1.telefonos = new Telefonos[] { t1, t2};

            Clientes cliente2 = new Clientes();
            cliente2.nombre = "Marcos Perez";
            cliente2.telefonos = new Telefonos[] { t3};

            Clientes cliente3 = new Clientes();
            cliente3.nombre = "Cesar Delgado";
            cliente3.telefonos = new Telefonos[] { t4, t5, t6};

            List<Clientes> list = new List<Clientes>();
            list.Add(cliente1);
            list.Add(cliente2);
            list.Add(cliente3);

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        private class Clientes
        {
            public string nombre { get; set; }
            public Telefonos[] telefonos { get; set; }
        }

        private class Telefonos
        {
            public string numero { get; set; }
            public double costo { get; set; }
            public bool activo { get; set; }
        }
    }
}