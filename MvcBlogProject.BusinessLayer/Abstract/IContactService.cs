using MvcBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.BusinessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> GetAllBL();
        Contact GetByIdBL(int id);
        void ContactAddBL(Contact contact);
        void ContactDeleteBL(Contact contact);
        void ContactUpdateBL(Contact contact);
    }
}
