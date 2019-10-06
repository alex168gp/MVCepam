using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCepam.Web.Controllers
{
    public class QuestionnaireController : Controller
    {
        // GET: Questionnaire
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string first, string second, string third)
        {
            return RedirectToAction("ShowQuestionnaireResult", new { first = first, second = second, third = third });
        }

        public ActionResult ShowQuestionnaireResult(string first, string second, string third)
        {
            ViewBag.First = first;
            ViewBag.Second = second;
            ViewBag.Third = third;
            return View();
        }
    }
}