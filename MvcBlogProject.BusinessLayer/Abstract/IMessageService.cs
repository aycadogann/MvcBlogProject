using MvcBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.BusinessLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> GetListInboxBL();
        List<Message> GetListSendboxBL();
        Message GetByIdBL(int id);
        void MessageAddBL(Message message);
        void MessageDeleteBL(Message message);
        void MessageUpdateBL(Message message);
    }
}
