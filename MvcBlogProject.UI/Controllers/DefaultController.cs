using MvcBlogProject.BusinessLayer.Concrete;
using MvcBlogProject.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.UI.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        ContentManager contentManager = new ContentManager(new EfContentDal());
        public ActionResult Headings()
        {
            var headingList=headingManager.GetAllBL();
            return View(headingList);
        }

        public PartialViewResult Index(int id=0)
        {
            var contentList = contentManager.GetByHeadingIdBL(id);
            return PartialView(contentList);
        }
    }
}