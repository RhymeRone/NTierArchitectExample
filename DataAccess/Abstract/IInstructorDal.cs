﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierArchitectExample.Entities;

namespace NTierArchitectExample.DataAccess.Abstract
{
    public interface IInstructorDal
    {
        public bool Add(Instructor instructor);
        public bool Update(Instructor instructor);
        public bool Delete(int id);
        public Instructor GetInstructor(int id);
        public List<Instructor> GetAllInstructors();
    }
}
