using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitectExample.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public string ProfilePictureURL { get; set; }

        public Instructor(int id, string name, string description, int age, string profilePictureUrl)
        {
            Id = id;
            Name = name;
            Description = description;
            Age = age;
            ProfilePictureURL = profilePictureUrl;
        }
    }
}
