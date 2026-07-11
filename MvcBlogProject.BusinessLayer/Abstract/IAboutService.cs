using MvcBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetAllBL();
        About GetByIdBL(int id);
        void AboutAddBL(About about);
        void AboutDeleteBL(About about);
        void AboutUpdateBL(About about);
    }
}
