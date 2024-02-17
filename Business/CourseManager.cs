using NTierArchitectExample.DataAccess.Abstract;
using NTierArchitectExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitectExample.Business
{
    public class CourseManager
    {
        private ICourseDal _icourseDal;

        public CourseManager(ICourseDal icourseDal)
        {
            _icourseDal = icourseDal;
        }

        public bool Add(Course course)
        {
            return _icourseDal.Add(course);
        }

        public bool Update(Course course)
        {
            return _icourseDal.Update(course);
        }

        public bool Delete(int id)
        {
            return _icourseDal.Delete(id);
        }

        public List<Course> GetAllCourses()
        {
            return _icourseDal.GetAllCourses();
        }

        public Course GetCategory(int id)
        {
            return _icourseDal.GetCourse(id);
        }
    }
}
