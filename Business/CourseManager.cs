using NTierArchitectExample.DataAccess.Abstract;
using NTierArchitectExample.DataAccess.Concrete;
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
        private readonly ICourseDal _icourseDal;

        public CourseManager(ICourseDal icourseDal)
        {
            _icourseDal = icourseDal;
        }

        public bool Add(Course course)
        {
            return _icourseDal.Add(course);
        }
        public bool AddRange(params Course[] courses)
        {
            // Mantık şu, bu metod birden çok course eklemeyi destekler, olurda bir course
            // ekleyemez ise eklediklerini de geri çıkarıp false döndürür. Böylece metod üzerinde
            // tam kontrol sağlarız.
            bool isComplate = true;
            List<Course> addedCourses = new List<Course>();
            foreach (var course in courses)
            {
                if (_icourseDal.Add(course))
                {
                    _icourseDal.Add(course);
                }
                else
                {
                    isComplate = false;
                    break;
                }
            }
            if (!isComplate)
            {
                foreach (var course in addedCourses)
                {
                    _icourseDal.Delete(course.Id);
                }
            }
            return isComplate;
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

        public Course GetCourse(int id)
        {
            return _icourseDal.GetCourse(id);
        }
    }
}
