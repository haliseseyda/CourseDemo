using CourseDemo.DataAccess.Concrete;
using CourseDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDemo.DataAccess.Abstract;

public interface IInstructorDal
{
    List<Instructor> GetAll();
    void Add(Instructor instructor);
}

