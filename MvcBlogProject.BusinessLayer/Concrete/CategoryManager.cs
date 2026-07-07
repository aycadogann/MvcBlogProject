using MvcBlogProject.BusinessLayer.Abstract;
using MvcBlogProject.DataAccessLayer.Abstract;
using MvcBlogProject.DataAccessLayer.Concrete.Repositories;
using MvcBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAllBL()
        {
            return _categoryDal.GetAll();
        }

    }
}
