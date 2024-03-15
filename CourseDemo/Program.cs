// See https://aka.ms/new-console-template for more information
using CourseDemo.Busines;
using CourseDemo.DataAccess.Abstract;
using CourseDemo.DataAccess.Concrete;
using CourseDemo.Entities;

Console.WriteLine("Hello, World!");

CourseManager courseManager = new(new CourseDal());
List<Course> courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Instructor);
}

CategoryManager categoryManager = new(new CategoryDal());
List<Category> categorys2 = categoryManager.GetAll();

for (int i = 0; i < categorys2.Count; i++)
{
    Console.WriteLine(categorys2[i].Id + "/" + categorys2[i].Description);
}

InstructorManager instructorManager = new(new InstructorDal());
List<Instructor> instructor2 = instructorManager.GetAll();

for (int i = 0; i < instructor2.Count; i++)
{
    Console.WriteLine(instructor2[i].Id + "/" + instructor2[i].FirstName);
}
