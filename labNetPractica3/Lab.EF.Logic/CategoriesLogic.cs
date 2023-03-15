using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CategoriesLogic
    {
        private NorthWindContext _northWindContext;

        public CategoriesLogic()
        {
            _northWindContext = new NorthWindContext();
        }

        public List<Categories> GetAll()
        {
            return _northWindContext.Categories.ToList();
        }
    }
}
