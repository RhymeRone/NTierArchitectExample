using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierArchitectExample.DataAccess.Abstract;
using NTierArchitectExample.Entities;

namespace NTierArchitectExample.DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        private List<Instructor> _instructors;

        public InstructorDal()
        {
            _instructors = new List<Instructor>();
        }
        public bool Add(Instructor instructor)
        {
            var _instructor = _instructors.Where(c => c.Id == instructor.Id).FirstOrDefault();
            if (_instructor == null)
            {
                _instructors.Add(instructor);
                return true;
            }
            return false;
        }

        public bool Update(Instructor instructor)
        {
            var _instructor = _instructors.Where(c => c.Id == instructor.Id).FirstOrDefault();
            if (_instructor != null)
            {
                _instructor.Name = instructor.Name;
                _instructor.Description = instructor.Description;
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var _instructor = _instructors.Where(c => c.Id == id).FirstOrDefault();
            return _instructors.Remove(_instructor);
        }

        public Instructor GetInstructor(int id)
        {
            return _instructors.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Instructor> GetAllInstructors()
        {
            return _instructors;
        }
    }
}
