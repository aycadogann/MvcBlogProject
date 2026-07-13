using MvcBlogProject.BusinessLayer.Abstract;
using MvcBlogProject.DataAccessLayer.Abstract;
using MvcBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message GetByIdBL(int id)
        {
            return _messageDal.Get(x => x.MessageID == id);
        }

        public List<Message> GetListInboxBL()
        {
            return _messageDal.GetAll(x => x.ReceiverMail == "admin@gmail.com");

        }

        public List<Message> GetListSendboxBL()
        {
            return _messageDal.GetAll(x => x.SenderMail == "admin@gmail.com");

        }

        public void MessageAddBL(Message message)
        {
            _messageDal.Insert(message);
        }

        public void MessageDeleteBL(Message message)
        {
            throw new NotImplementedException();
        }

        public void MessageUpdateBL(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
