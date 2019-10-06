using MVCepam.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCepam.Web.Controllers
{
    public class GuestController : Controller
    {
        private GenericRepository<Review> repository;

        public GuestController()
        {
            this.repository = new GenericRepository<Review>(new BlogContentContext());
        }

        // GET: Guest
        public ActionResult GuestBoard()
        {

            return View(repository.Get());
        }

        [HttpPost]
        public ActionResult GuestBoard(string commentAuthorName, string commentText)
        {
            ViewBag.Title = commentAuthorName;
            ViewBag.Message = commentText;
            return View();
        }
    }
}