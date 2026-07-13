using MvcBlogProject.BusinessLayer.Concrete;
using MvcBlogProject.BusinessLayer.ValidationRules;
using MvcBlogProject.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.UI.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager contactManager = new ContactManager(new EfContactDal());
        ContactValidator contactValidator = new ContactValidator();
        public ActionResult Index()
        {
            var contactValues = contactManager.GetAllBL();
            return View(contactValues);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactValue = contactManager.GetByIdBL(id);
            return View(contactValue);
        }

        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }

    }
}