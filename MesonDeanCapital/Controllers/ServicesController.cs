using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MesonDeanCapital.Controllers {
	public class ServicesController : Controller {
		// GET: Services
		public ActionResult Index() {
			ViewBag.Title = "Services";
			return View();
		}

		public ActionResult ManagedFutures() {
			ViewBag.Title = "Managed-Futures";
			return View();
		}

		public ActionResult CareerTraining() {
			ViewBag.Title = "Career-Training";
			return View();
		}

		public ActionResult TradingTools() {
			ViewBag.Title = "Trading-Tools";
			return View();
		}
	}
}