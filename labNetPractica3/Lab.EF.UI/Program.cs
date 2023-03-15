using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.EF.Entities;
using Lab.EF.Logic;

namespace Lab.EF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "products");

            ProductLogic productLogic = new ProductLogic();

            var products = productLogic.GetAll();

            foreach( var product in products )
            {
                Console.WriteLine(  product.ProductName);
            }

            RegionLogic regionLogic = new RegionLogic();

            var regions = regionLogic.GetAll();

            Console.WriteLine("regions");

            foreach ( var region in regions )
            {
                Console.WriteLine(  region.RegionDescription);
            }

            Console.ReadLine();
        }
    }
}
