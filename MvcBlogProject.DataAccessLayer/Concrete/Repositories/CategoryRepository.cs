using MvcBlogProject.DataAccessLayer.Abstract;
using MvcBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context context = new Context();
        DbSet<Category> _object;
        public void Delete(Category category)
        {
            _object.Remove(category);
            context.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return _object.ToList();
        }

        public List<Category> GetById(Expression<Func<Category, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Insert(Category category)
        {
            _object.Add(category);
            context.SaveChanges();
        }

        public void Update(Category category)
        {
            context.SaveChanges();
        }
    }
}
