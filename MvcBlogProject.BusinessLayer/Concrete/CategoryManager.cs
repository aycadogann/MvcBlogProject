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

        public void CategoryAddBL(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryDeleteBL(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdateBL(Category category)
        {
            _categoryDal.Update(category);
        }

        public List<Category> GetAllBL()
        {
            return _categoryDal.GetAll();
        }

        public Category GetByIdBL(int id)
        {
            return _categoryDal.Get(x=>x.CategoryID==id);
        }
    }
}
