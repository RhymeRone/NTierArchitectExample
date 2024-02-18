using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierArchitectExample.Business;
using NTierArchitectExample.DataAccess.Concrete;
using NTierArchitectExample.Entities;

namespace NTierArchitectExample
{
    static class Program
    { 
        static void Main(string[] args)
        {
            CourseManager courseManager = new CourseManager(new CourseDal());
            InstructorManager instructorManager = new InstructorManager(new InstructorDal());
            CategoryManager categoryManager = new CategoryManager(new CategoryDal());

            instructorManager.AddRange(
                new Instructor(0, "İsmail Hallaç", "Java Full Stack Dev.", 27, "default"),
                new Instructor(1,"Engin Demiröğ","Full Stack",99,"")
            );

            categoryManager.AddRange(
                new Category(0, "Java", "Java ile alakalı her şey"),
                new Category(1, "C#", "C# ile alakalı her şey"));
            
            courseManager.AddRange(
                new Course(0,
                    categoryManager.GetCategory(0).Id, //Burada id'i kontrol sağlayarak yazıyorum.
                    instructorManager.GetInstructor(0).Id,
                    "Java Kursu","Java 2 Aylık Bootcamp")
            );

            Console.WriteLine("<-------- Eğitmenler --------->");
            foreach (var instructor in instructorManager.GetAllInstructors())
            {
                Console.WriteLine("\nEğitmen No : " + instructor.Id);
                Console.WriteLine("Eğitmen Adı : "+instructor.Name);
                Console.WriteLine("Eğitmen Yaşı : " + instructor.Age);
                Console.WriteLine("Eğitmen Açıklaması : " + instructor.Description);
                Console.WriteLine("Eğitmen Profil Resmi : " + instructor.ProfilePictureURL);
            }

            Console.WriteLine("\n<-------- Kategoriler --------->");
            foreach (var category in categoryManager.GetAllCategories())
            {
                Console.WriteLine("\nKategori No : " + category.Id);
                Console.WriteLine("Kategori Adı : " + category.Name);
                Console.WriteLine("Kategori Açıklaması : " + category.Description);
            }

            Console.WriteLine("\n<-------- Kurslar --------->");
            foreach (var course in courseManager.GetAllCourses())
            {
                Console.WriteLine("\nKurs No : " + course.Id);
                Console.WriteLine("Kurs Adı : " + course.Name);
                Console.WriteLine("Kurs Açıklaması : " + course.Description);
                Console.WriteLine("Kurs Kategorisi : " + categoryManager.GetCategory(course.CategoryId).Name);
                Console.WriteLine("Kurs Eğitmeni : " + instructorManager.GetInstructor(course.InstructorId).Name);
            }

        }

    }
}
