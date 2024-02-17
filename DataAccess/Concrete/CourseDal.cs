using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierArchitectExample.DataAccess.Abstract;
using NTierArchitectExample.Entities;

namespace NTierArchitectExample.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        private List<Course> _courses;

        public CourseDal()
        {
            _courses = new List<Course>();
        }
        public bool Add(Course course)
        {
            var _course = _courses.Where(c => c.Id == course.Id).FirstOrDefault();
            if (_course == null)
            {
                _courses.Add(course);
                return true;
            }
            return false;
        }

        public bool Update(Course course)
        {
            var _course = _courses.Where(c => c.Id == course.Id ).FirstOrDefault();
            if (_course != null)
            {
                _course.Name = course.Name;
                _course.Description = course.Description;
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Course GetCourse(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAllCourses()
        {
            throw new NotImplementedException();
        }
    }
}
