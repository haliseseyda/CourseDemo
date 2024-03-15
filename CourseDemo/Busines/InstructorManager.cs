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
    public class InstructorManager
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal) 
        {
            _instructorDal = instructorDal;
        }

        public List<Instructor> GetAll() 
        {
            return _instructorDal.GetAll();
        }

        public void Add(Instructor instructor)
        {
            Console.WriteLine(instructor.FirstName);
        }

        public void Update(Instructor instructor)
        {
            Console.WriteLine(instructor.FirstName);
        }

        public void Delete(Instructor instructor)
        {
            Console.WriteLine(instructor.Id);
        }

        public void Read(Instructor instructor)
        {
            Console.WriteLine(instructor.FirstName);
        }
    }
}
