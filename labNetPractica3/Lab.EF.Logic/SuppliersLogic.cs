using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class SuppliersLogic
    {
        private NorthWindContext _northWindContext;

        public SuppliersLogic()
        {
            _northWindContext = new NorthWindContext();
        }

        public List<Suppliers> GetAll()
        {
            return _northWindContext.Suppliers.ToList();
        }
    }
}
