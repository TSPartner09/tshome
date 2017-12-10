using BotDetect.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeSculpting.Models;
using TimeSculpting.ViewModels;

namespace TimeSculpting.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var vm = new HomeIndexVM();
            return View(vm);
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        [CaptchaValidation("CaptchaCode", "ExampleCaptcha", "Incorrect CAPTCHA code!")]
        public JsonResult RequestConsultation(ConsultationRequest consultationRequest)
        {
            var success = false;

            if (ModelState.IsValid)
            {
                using (var db = new ApplicationDbContext())
                {
                    consultationRequest.DateOfRequest = DateTime.Now;
                    db.ConsultationRequests.Add(consultationRequest);
                    db.SaveChanges();
                    success = true;
                }
            }

            return Json(new { success = success });
        }
    }
}