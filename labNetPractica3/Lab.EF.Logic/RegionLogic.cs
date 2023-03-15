using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class RegionLogic : BaseLogic, IABMLogic<Region>
    {
     
        public void Delete(Region item)
        {
            throw new NotImplementedException();
        }

        public List<Region> GetAll()
        {
            return _northWindContext.Region.ToList();
        }

        public int GetId(Region item)
        {
            throw new NotImplementedException();
        }

        public void Insert(Region item)
        {
            throw new NotImplementedException();
        }

        public void Update(Region item)
        {
            throw new NotImplementedException();
        }
    }
}
