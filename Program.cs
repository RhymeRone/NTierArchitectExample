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

            Course course = new Course(0, "C#", "Eğitim Kampı");
            Instructor instructor = new Instructor(0, "İsmail Hallaç", "Eğitmen",26, "");
            Category category = new Category(0, "Backend", "");

            

        }

    }
}
