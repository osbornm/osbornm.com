using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySite.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "Take the time to get to know me.";

            return View();
        }

        public ActionResult Resume() {
            ViewBag.Message = "Work history and education.";

            return View();
        }

        public ActionResult Talks() {
            ViewBag.Message = "A collection of samples, slides, and videos.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "How you should get ahold of me.";

            return View();
        }
    }
}
