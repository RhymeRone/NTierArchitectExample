using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierArchitectExample.Entities;

namespace NTierArchitectExample.DataAccess.Abstract
{
    public interface ICourseDal
    {
        public bool Add(Course course);
        public bool Update(Course course);
        public bool Delete(int id);
        public Course GetCourse(int id);
        public List<Course> GetAllCourses();
    }
}
