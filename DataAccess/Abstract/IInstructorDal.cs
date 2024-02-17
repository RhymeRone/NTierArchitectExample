using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierArchitectExample.Entities;

namespace NTierArchitectExample.DataAccess.Abstract
{
    public interface IInstructorDal
    {
        public void Add(Instructor instructor);
        public void Update(Instructor instructor);
        public void Delete(int Id);
        public Instructor GetInstructor(int Id);
        public List<Instructor> GetAll();
    }
}
