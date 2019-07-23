using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MesonDeanCapital.Controllers {
	public class ProductsController : Controller {
		// GET: Products
		public ActionResult Index() {
			ViewBag.Title = "Products";
			return View();
		}

		public ActionResult Forex() {
			ViewBag.Title = "Forex";
			return View();
		}

		public ActionResult Futures() {
			ViewBag.Title = "Futures";
			return View();
		}

		public ActionResult Metals() {
			ViewBag.Title = "Metals";
			return View();
		}
	}
}