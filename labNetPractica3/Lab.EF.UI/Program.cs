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
            Console.WriteLine("categories");

            IABMLogic<Categories> categoriesLogic = new CategoriesLogic();
            
            var categories = categoriesLogic.GetAll();

            foreach (var category in categories)
            {
                Console.WriteLine(  category.CategoryName);
            }

            Console.WriteLine("suppliers");

            IABMLogic<Suppliers> suppliersLogic = new SuppliersLogic();

            var suppliers = suppliersLogic.GetAll();

            foreach (var supply in suppliers)
            {
                Console.WriteLine(supply.CompanyName);
            }

            Console.ReadLine();
        }
    }
}
