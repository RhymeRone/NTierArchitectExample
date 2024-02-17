using NTierArchitectExample.DataAccess.Abstract;
using NTierArchitectExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitectExample.Business
{
    public class InstructorManager
    {
        private IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public bool Add(Instructor instructor)
        {
            return _instructorDal.Add(instructor);
        }

        public bool Update(Instructor instructor)
        {
            return _instructorDal.Update(instructor);
        }

        public bool Delete(int id)
        {
            return _instructorDal.Delete(id);
        }

        public List<Instructor> GettAllInstructors()
        {
            return _instructorDal.GetAllInstructors();
        }

        public Instructor GetInstructor(int id)
        {
            return _instructorDal.GetInstructor(id);
        }
    }
}
