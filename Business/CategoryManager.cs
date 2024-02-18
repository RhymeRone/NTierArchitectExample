using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierArchitectExample.DataAccess.Abstract;
using NTierArchitectExample.DataAccess.Concrete;
using NTierArchitectExample.Entities;

namespace NTierArchitectExample.Business
{
    public class CategoryManager
    {
        private readonly ICategoryDal _icategoryDal;

        public CategoryManager(ICategoryDal icategorydal)
        {
            _icategoryDal = icategorydal;
        }

        public bool Add(Category category)
        {
            return _icategoryDal.Add(category);
        }
        public bool AddRange(params Category[] categories)
        {
            // Mantık şu, bu metod birden çok category eklemeyi destekler, olurda bir category
            // ekleyemez ise eklediklerini de geri çıkarıp false döndürür. Böylece metod üzerinde
            // tam kontrol sağlarız.
            bool isComplate = true;
            List<Category> addedCategories = new List<Category>();
            foreach (var category in categories)
            {
                if (_icategoryDal.Add(category))
                {
                    addedCategories.Add(category);
                }
                else
                {
                    isComplate = false;
                    break;
                }
            }
            if (!isComplate)
            {
                foreach (var category in addedCategories)
                {
                    _icategoryDal.Delete(category.Id);
                }
            }
            return isComplate;
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
