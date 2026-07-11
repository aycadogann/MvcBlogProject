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
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public List<Heading> GetAllBL()
        {
            return _headingDal.GetAll();
        }

        public Heading GetByIdBL(int id)
        {
            return _headingDal.Get(x=>x.HeadingID==id);
        }

        public void HeadingAddBL(Heading heading)
        {
            _headingDal.Insert(heading);
        }

        public void HeadingDeleteBL(Heading heading)
        {
            _headingDal.Update(heading);
        }

        public void HeadingUpdateBL(Heading heading)
        {
            _headingDal.Update(heading);
        }
    }
}
