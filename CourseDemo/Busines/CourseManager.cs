using CourseDemo.DataAccess.Abstract;
using CourseDemo.DataAccess.Concrete;
using CourseDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDemo.Busines
{
    public class CourseManager
    {

        private readonly ICourseDal _courseDal;   //Doğru olan bu

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll() //void döndürmez
        {
            return _courseDal.GetAll();
        }

        //public CourseDal CourseDal { get; }

        public void Add(Course course)
        {
            Console.WriteLine(course.Name);
        }

        public void Update(Course course)
        {
            Console.WriteLine(course.Description);
        }

        public void Delete(Course course)
        {
            Console.WriteLine(course.Id);
        }

        public void Read(Course course)
        {
            Console.WriteLine(course.Description);
        }
    }
}
