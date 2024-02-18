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
                _course.CategoryId = course.CategoryId;
                _course.InstructorId = course.InstructorId;
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var _course = _courses.Where(c=>c.Id== id).FirstOrDefault();
            return _courses.Remove(_course);
        }

        public Course GetCourse(int id)
        {
            return _courses.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Course> GetAllCourses()
        {
            return _courses;
        }
    }
}
