using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MesonDeanCapital.Controllers
{
    public class SupportController : Controller
    {
        // GET: Support
        public ActionResult Index()
        {
			ViewBag.Title = "Support";
            return View();
        }

		public ActionResult Contact() {
			ViewBag.Title = "Contact";
			return View();
		}

		public ActionResult NewAccount() {
			ViewBag.Title = "New-Account";
			return View();
		}
	}
}