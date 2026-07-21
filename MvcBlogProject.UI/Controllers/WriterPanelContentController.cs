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
    public class WriterPanelContentController : Controller
    {
        // GET: WriterPanelContent
        ContentManager contentManager = new ContentManager(new EfContentDal());
        Context context = new Context();
        public ActionResult MyContent(string value)
        {
            value = (string)Session["WriterMail"];
            var writerIdInfo = context.Writers.Where(x => x.WriterMail == value).Select(y => y.WriterID).FirstOrDefault();
            var contentValues = contentManager.GetByWriterBL(writerIdInfo);
            return View(contentValues); 
        }

        [HttpGet]
        public ActionResult AddContent(int id)
        {
            ViewBag.id = id;
            return View();
        }

        [HttpPost]
        public ActionResult AddContent(Content content)
        {
            string mail = (string)Session["WriterMail"];
            var writerIdInfo = context.Writers.Where(x => x.WriterMail == mail).Select(y => y.WriterID).FirstOrDefault();
            
            content.ContentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            content.WriterID = writerIdInfo;
            content.ContentStatus = true;
            contentManager.ContentAddBL(content);
            return RedirectToAction("MyContent");
        }


    }
}