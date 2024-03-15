using CourseDemo.DataAccess.Abstract;
using CourseDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDemo.Busines
{
    public class CategoryManager
    {
        private readonly ICategoryDal _categoryDal;   //Doğru olan bu

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll() //void döndürmez
        {
            return _categoryDal.GetAll();
        }

        public void Add(Category category)
        {
            Console.WriteLine(category.Description);
        }

        public void Update(Category category)
        {
            Console.WriteLine(category.Description);
        }

        public void Delete(Category category)
        {
            Console.WriteLine(category.Id);
        }

        public void Read(Category category)
        {
            Console.WriteLine(category.Description);
        }
    }
}
