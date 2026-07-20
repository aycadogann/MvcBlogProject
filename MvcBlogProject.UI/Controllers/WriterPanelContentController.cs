using MvcBlogProject.BusinessLayer.Concrete;
using MvcBlogProject.DataAccessLayer.Concrete;
using MvcBlogProject.DataAccessLayer.EntityFramework;
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
        public ActionResult MyContent(string value)
        {
            Context context = new Context();
            value = (string)Session["WriterMail"];
            var writerIdInfo = context.Writers.Where(x => x.WriterMail == value).Select(y => y.WriterID).FirstOrDefault();
            var contentValues = contentManager.GetByWriterBL(writerIdInfo);
            return View(contentValues); 
        }
    }
}