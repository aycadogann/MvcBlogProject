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
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        WriterManager writerManager = new WriterManager(new EfWriterDal());

        public ActionResult Index()
        {
            var headingValues = headingManager.GetAllBL();
            return View(headingValues);
        }

        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> _categoryValues = (from x in categoryManager.GetAllBL()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.CategoryName,
                                                        Value = x.CategoryID.ToString()
                                                    }).ToList();
            ViewBag.categoryValues = _categoryValues;

            List<SelectListItem> _writerValues = (from x in writerManager.GetAllBL()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.WriterName + " " + x.WriterSurname,
                                                      Value = x.WriterID.ToString()
                                                  }).ToList();
            ViewBag.writerValue = _writerValues;
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading heading)
        {
            heading.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            headingManager.HeadingAddBL(heading);
            return RedirectToAction("Index");
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
            return RedirectToAction("Index");
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

            return RedirectToAction("Index");
        }
    }
}