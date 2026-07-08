using MvcBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAllBL();
        Category GetByIdBL(int id);
        void CategoryAddBL(Category category);
        void CategoryDeleteBL(Category category);
        void CategoryUpdateBL(Category category);
    }
}
