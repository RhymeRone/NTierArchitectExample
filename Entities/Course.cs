using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitectExample.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Course(int id, int categoryId, int instructorId, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
            CategoryId = categoryId;
            InstructorId = instructorId;
        }
    }
}
