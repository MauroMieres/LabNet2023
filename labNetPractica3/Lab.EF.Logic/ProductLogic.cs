using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.EF.Entities;
using Lab.EF.Data;

namespace Lab.EF.Logic
{
    public class ProductLogic : BaseLogic, IABMLogic<Products>
    {
        
        public void Delete(Products item)
        {
            throw new NotImplementedException();
        }

        public List<Products> GetAll()
        {
            return _northWindContext.Products.ToList();
        }

        public int GetId(Products item)
        {
            throw new NotImplementedException();
        }

        public void Insert(Products item)
        {
            throw new NotImplementedException();
        }

        public void Update(Products item)
        {
            throw new NotImplementedException();
        }
    }
}
