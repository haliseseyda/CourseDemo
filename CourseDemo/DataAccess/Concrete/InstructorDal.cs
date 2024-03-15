using CourseDemo.DataAccess.Abstract;
using CourseDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDemo.DataAccess.Concrete
{
    public class InstructorDal:IInstructorDal
    {
        List<Instructor> instructors;

        public InstructorDal()
        {

            Instructor instructor1 = new Instructor();
            instructor1.Id = 1;
            instructor1.FirstName = "Engin";
            instructor1.LastName = "Demiroğ";

            Instructor instructor2 = new Instructor();
            instructor2.Id = 2;
            instructor2.FirstName = "Murat";
            instructor2.LastName = "Yücedağ";

            instructors = new List<Instructor> { instructor1, instructor2 };
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }
    }
}
