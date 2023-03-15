using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class SuppliersLogic : BaseLogic, IABMLogic<Suppliers>
    {
        public void Delete(Suppliers item)
        {
            throw new NotImplementedException();
        }

        public List<Suppliers> GetAll()
        {
            return _northWindContext.Suppliers.ToList();
        }

        public int GetId(Suppliers item)
        {
            throw new NotImplementedException();
        }

        public void Insert(Suppliers item)
        {
            throw new NotImplementedException();
        }

        public void Update(Suppliers item)
        {
            throw new NotImplementedException();
        }
    }
}
