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
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public bool Add(Instructor instructor)
        {
            return _instructorDal.Add(instructor);
        }

        public bool AddRange(params Instructor[] instructors)
        {
            // Mantık şu, bu metod birden çok instructor eklemeyi destekler, olurda bir instructor
            // ekleyemez ise eklediklerini de geri çıkarıp false döndürür. Böylece metod üzerinde
            // tam kontrol sağlarız.
            bool isComplate = true;
            List<Instructor> addedInstructors = new List<Instructor>();
            foreach (var instructor in instructors)
            {
                if (_instructorDal.Add(instructor))
                {
                    addedInstructors.Add(instructor);
                }
                else
                {
                    isComplate = false;
                    break;
                }
            }
            if (!isComplate)
            {
                foreach (var instructor in addedInstructors)
                {
                    _instructorDal.Delete(instructor.Id);
                }
            }
            return isComplate;
        }

        public bool Update(Instructor instructor)
        {
            return _instructorDal.Update(instructor);
        }

        public bool Delete(int id)
        {
            return _instructorDal.Delete(id);
        }

        public List<Instructor> GetAllInstructors()
        {
            return _instructorDal.GetAllInstructors();
        }

        public Instructor GetInstructor(int id)
        {
            return _instructorDal.GetInstructor(id);
        }
    }
}
