using FluentValidation.Results;
using MvcBlogProject.BusinessLayer.Concrete;
using MvcBlogProject.BusinessLayer.ValidationRules;
using MvcBlogProject.DataAccessLayer.EntityFramework;
using MvcBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.UI.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        MessageValidator messageValidator = new MessageValidator();
        public ActionResult Inbox()
        {
            var messageList = messageManager.GetListInboxBL();
            return View(messageList);
        }

        public ActionResult GetInboxMessageDetails(int id)
        {
            var value = messageManager.GetByIdBL(id);
            return View(value);
        }

        public ActionResult GetSendboxMessageDetails(int id)
        {
            var value = messageManager.GetByIdBL(id);
            return View(value);
        }

        public ActionResult Sendbox()
        {
            var messageList = messageManager.GetListSendboxBL();
            return View(messageList);
        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message message)
        {

            ValidationResult results = messageValidator.Validate(message);
            if (results.IsValid)
            {
                message.MessageDate=DateTime.Parse(DateTime.Now.ToShortDateString());
                messageManager.MessageAddBL(message);
                return RedirectToAction("Sendbox");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}