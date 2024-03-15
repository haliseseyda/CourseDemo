using CourseDemo.DataAccess.Abstract;
using CourseDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDemo.DataAccess.Concrete
{
    public class CategoryDal:ICategoryDal
    {
        List<Category> categorys;

        public CategoryDal()
        {
            Category category1 = new Category();
            category1.Id = 1;
            category1.Description = "Tümü";

            Category category2 = new Category();
            category2.Id = 2;
            category2.Description = "Programlama(8)";

            categorys = new List<Category> { category1, category2 };
        }

        public List<Category> GetAll() //Koleksiyon 
        {
            return categorys;
        }

        public void Add(Category category)
        {
            categorys.Add(category);
        }
    }
}
