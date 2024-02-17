using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierArchitectExample.DataAccess.Abstract;
using NTierArchitectExample.Entities;

namespace NTierArchitectExample.Business
{
    public class CategoryManager
    {
        private ICategoryDal _icategoryDal;

        public CategoryManager(ICategoryDal icategorydal)
        {
            _icategoryDal = icategorydal;
        }

        public bool Add(Category category)
        {
            return _icategoryDal.Add(category);
        }

        public bool Update(Category category)
        {
            return _icategoryDal.Update(category);
        }

        public bool Delete(int id)
        {
            return _icategoryDal.Delete(id);
        }

        public List<Category> GetAllCategories()
        {
            return _icategoryDal.GetAllCategories();
        }

        public Category GetCategory(int id)
        {
            return _icategoryDal.GetCategory(id);
        }

    }
}
