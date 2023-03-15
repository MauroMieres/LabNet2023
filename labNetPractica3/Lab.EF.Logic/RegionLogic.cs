using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class RegionLogic
    {
        private NorthWindContext _northWindContext;

        public RegionLogic()
        {
            _northWindContext = new NorthWindContext();
        }

        public List<Region> GetAll()
        {
            return _northWindContext.Region.ToList();
        }
    }
}
