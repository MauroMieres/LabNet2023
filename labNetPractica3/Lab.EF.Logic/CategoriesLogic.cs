using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Categories>
    {
   
        public List<Categories> GetAll()
        {
            return _northWindContext.Categories.ToList();
        }

        public int GetId(Categories item)
        {
            throw new NotImplementedException();
        }

        public void Insert(Categories item)
        {
            throw new NotImplementedException();
        }

        public void Update(Categories item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Categories item)
        {
            throw new NotImplementedException();
        }

        //public void AddCategory(Categories category)
        //{
        //    if (category == null)
        //    {
        //        throw new ArgumentNullException(nameof(category));
        //    }
        //    _northWindContext.Categories.Add(category);
        //    _northWindContext.SaveChanges(); 
        //}
    }
}
