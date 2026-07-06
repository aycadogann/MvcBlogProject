using MvcBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
        void Insert(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}
