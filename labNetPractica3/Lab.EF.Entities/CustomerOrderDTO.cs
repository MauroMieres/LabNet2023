using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Entities
{
    public class CustomerOrderDTO
    {
        public string CustomerName { get; set; }
        public int OrderID { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
