using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.EF.Entities;
using Lab.EF.Data;

namespace Lab.EF.Logic
{
    public class ProductLogic
    {
        private NorthWindContext _northWindContext;

        public ProductLogic()
        {
            _northWindContext = new NorthWindContext();
        }

        public List<Products> GetAll()
        {
            return _northWindContext.Products.ToList();
        }
    }
}
