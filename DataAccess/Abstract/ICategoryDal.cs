using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierArchitectExample.Entities;

namespace NTierArchitectExample.DataAccess.Abstract
{
    public interface ICategoryDal
    {
        public bool Add(Category category);
        public bool Update(Category category);
        public bool Delete(int id);
        public Category GetCategory(int id);
        public List<Category> GetAllCategories();

    }
}
