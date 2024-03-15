using CourseDemo.DataAccess.Abstract;
using CourseDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDemo.DataAccess.Concrete;

public class CourseDal:ICourseDal
{
    List<Course> courses;

    public CourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Instructor = "Engin Demiroğ";
        course1.Description = "2024 Yazılım Geliştirici Yetiştirme Kampı";

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "JavaScript";
        course2.Instructor = "Engin Demiroğ";
        course2.Description = "Yazılım Geliştirici Yetiştirme Kampı";

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Java + React";
        course3.Instructor = "Engin Demiroğ";
        course3.Description = "Yazılım Geliştirici Yetiştirme Kampı";

        courses = new List<Course> { course1, course2, course3 };
    }

    public List<Course> GetAll() //Koleksiyon 
    {
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
}

