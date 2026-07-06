using MvcBlogProject.DataAccessLayer.Concrete.Repositories;
using MvcBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repository = new GenericRepository<Category>();
        public List<Category> GetAllBL()
        {
            return repository.GetAll();
        }
        public void AddBL(Category category)
        {
            if (category.CategoryName=="" || category.CategoryName.Length<=3 || 
                category.CategoryDescription=="" || category.CategoryName.Length>=51)
            {
                //Hata mesajı
            }
            else
            {
                repository.Insert(category);
            }
        }
    }
}
