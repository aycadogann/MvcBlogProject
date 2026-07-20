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
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void ContentAddBL(Content content)
        {
            _contentDal.Insert(content);
        }

        public void ContentDeleteBL(Content content)
        {
            _contentDal.Delete(content);
        }

        public void ContentUpdateBL(Content content)
        {
            _contentDal.Update(content);
        }

        public List<Content> GetAllBL()
        {
            return _contentDal.GetAll();
        }

        public Content GetByIdBL(int id)
        {
            return _contentDal.Get(x => x.ContentID == id);
        }

        public List<Content> GetByHeadingIdBL(int id)
        {
            return _contentDal.GetAll(x => x.HeadingID == id);
        }

        public List<Content> GetByWriterBL(int id)
        {
            return _contentDal.GetAll(x => x.WriterID == id);
        }
    }
}
