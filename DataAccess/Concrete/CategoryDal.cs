using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierArchitectExample.DataAccess.Abstract;
using NTierArchitectExample.Entities;

namespace NTierArchitectExample.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        private List<Category> _categories;

        public CategoryDal()
        {
            _categories = new List<Category>();
        }
        public bool Add(Category category)
        {
            var _category = _categories.Where(c => c.Id == category.Id).FirstOrDefault();
            if (_category == null)
            {
                _categories.Add(category);
                return true;
            }
            return false;
        }

        public bool Update(Category category)
        {
            var _category = _categories.Where(c => c.Id == category.Id).FirstOrDefault();
            if (_category != null)
            {
                _category.Name = category.Name;
                _category.Description = category.Description;
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var _category = _categories.Where(c => c.Id == id).FirstOrDefault();
            return _categories.Remove(_category);
        }

        public Category GetCategory(int id)
        {
            return _categories.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Category> GetAllCategories()
        {
            return _categories;
        }
    }
}
