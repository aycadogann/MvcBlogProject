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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void AboutAddBL(About about)
        {
            _aboutDal.Insert(about);
        }

        public void AboutDeleteBL(About about)
        {
            _aboutDal.Delete(about);
        }

        public void AboutUpdateBL(About about)
        {
            _aboutDal.Update(about);
        }

        public List<About> GetAllBL()
        {
            return _aboutDal.GetAll();
        }

        public About GetByIdBL(int id)
        {
            return _aboutDal.Get(x => x.AboutID == id);
        }
    }
}
