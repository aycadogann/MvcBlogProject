using MvcBlogProject.BusinessLayer.Concrete;
using MvcBlogProject.DataAccessLayer.EntityFramework;
using MvcBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.UI.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var aboutValues = aboutManager.GetAllBL();
            return View(aboutValues);
        }

        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAbout(About about)
        {
            aboutManager.AboutAddBL(about);
            return RedirectToAction("Index");
        }

        public PartialViewResult AboutPartial()
        {

            return PartialView();
        }
    }
}