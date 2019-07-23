using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MesonDeanCapital.Controllers
{
    public class WhyUsController : Controller
    {
        // GET: WhyUs
        public ActionResult Index()
        {
			ViewBag.Title = "Why-Us";
			return View();
        }

		
		public ActionResult Overview() {
			ViewBag.Title = "Overview";
			return View();
		}

		public ActionResult USRegulated() {
			ViewBag.Title = "US-Regulated";
			return View();
		}

		public ActionResult CompetitiveSpreads() {
			ViewBag.Title = "Competitive Spreads";
			return View();
		}

		public ActionResult Rebates() {
			ViewBag.Title = "Rebates";
			return View();
		}
	}
}