using MvcBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBlogProject.BusinessLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetAllBL();
        Writer GetByIdBL(int id);
        void WriterAddBL(Writer writer);
        void WriterDeleteBL(Writer writer);
        void WriterUpdateBL(Writer writer);
    }
}
