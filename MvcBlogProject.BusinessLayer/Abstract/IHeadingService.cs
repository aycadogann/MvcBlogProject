using MvcBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetAllBL();
        Heading GetByIdBL(int id);
        void HeadingAddBL(Heading heading);
        void HeadingDeleteBL(Heading heading);
        void HeadingUpdateBL(Heading heading);
    }
}
