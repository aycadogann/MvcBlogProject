using MvcBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetAllBL();
        List<Content> GetByHeadingIdBL(int id);
        List<Content> GetByWriterBL(int id);
        Content GetByIdBL(int id);
        void ContentAddBL(Content content);
        void ContentDeleteBL(Content content);
        void ContentUpdateBL(Content content);
    }
}
