using MvcBlogProject.BusinessLayer.Concrete;
using MvcBlogProject.DataAccessLayer.Concrete;
using MvcBlogProject.DataAccessLayer.EntityFramework;
using MvcBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.UI.Controllers
{
    public class WriterPanelController : Controller
    {
        // GET: WriterPanel
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        Context context = new Context();

        public ActionResult WriterProfile()
        {
            return View();
        }

        public ActionResult MyHeading(string value)
        {
            value = (string)Session["WriterMail"];
            var writerIdInfo = context.Writers.Where(x => x.WriterMail == value).Select(y => y.WriterID).FirstOrDefault();
            var values = headingManager.GetAllByWriterBL(writerIdInfo);
            return View(values);
        }

        [HttpGet]
        public ActionResult NewHeading()
        {
            List<SelectListItem> _categoryValues = (from x in categoryManager.GetAllBL()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.CategoryName,
                                                        Value = x.CategoryID.ToString()
                                                    }).ToList();
            ViewBag.categoryValues = _categoryValues;
            return View();
        }

        [HttpPost]
        public ActionResult NewHeading(Heading heading)
        {
            string writerMail = (string)Session["WriterMail"];
            var writerIdInfo = context.Writers.Where(x => x.WriterMail == writerMail).Select(y => y.WriterID).FirstOrDefault();
            heading.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            heading.WriterID = writerIdInfo;
            heading.HeadingStatus = true;
            headingManager.HeadingAddBL(heading);
            return RedirectToAction("MyHeading");
        }

        [HttpGet]
        public ActionResult EditHeading(int id)
        {
            List<SelectListItem> _categoryValues = (from x in categoryManager.GetAllBL()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.CategoryName,
                                                        Value = x.CategoryID.ToString()
                                                    }).ToList();
            ViewBag.categoryValues = _categoryValues;

            var headingValue = headingManager.GetByIdBL(id);
            return View(headingValue);
        }

        [HttpPost]
        public ActionResult EditHeading(Heading heading)
        {
            headingManager.HeadingUpdateBL(heading);
            return RedirectToAction("MyHeading");
        }

        public ActionResult DeleteHeading(int id)
        {
            var headingValue = headingManager.GetByIdBL(id);
            if (headingValue.HeadingStatus == true)
            {
                headingValue.HeadingStatus = false;
                headingManager.HeadingDeleteBL(headingValue);
            }
            else
            {
                headingValue.HeadingStatus = true;
                headingManager.HeadingDeleteBL(headingValue);
            }

            return RedirectToAction("MyHeading");
        }

    }
}

//< system.web >

//      < customErrors mode = "On" >

//           < error statusCode = "404" redirect = "/ErrorPage/Page404/" />

//          </ customErrors >
