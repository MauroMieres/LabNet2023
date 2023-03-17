using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
{
    public class VistaQuerys
    {
        public static void Query1()
        {
            Console.WriteLine("1. Query para devolver objeto customer.");
            var customersLogic = new CustomersLogic();
            var allCustomers = customersLogic.GetAll();

            Customers query = allCustomers.FirstOrDefault(c => c.CustomerID == "ALFKI");

            Console.WriteLine($"Customer devuelto: \nID:{query.CustomerID} - {query.ContactName}");
        }

        public static void Query2()
        {
            Console.WriteLine("2. Query para devolver todos los productos sin stock.");
            var productLogic = new ProductLogic();
            var allProducts = productLogic.GetAll();
            List<Products> productosSinStock = allProducts.Where(p => p.UnitsInStock == 0).ToList();

            Console.WriteLine("Productos que no tienen stock:");
            foreach (Products product in productosSinStock)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        public static void Query3()
        {
            Console.WriteLine("3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad");
            var productLogic = new ProductLogic();
            var allProducts = productLogic.GetAll();

            List<Products> productosConStockMasDe3 = allProducts.Where(p => p.UnitPrice > 3 && p.UnitsInStock > 0).ToList();

            Console.WriteLine("Consulta devuelta:");
            foreach (Products product in productosConStockMasDe3)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        public static void Query4()
        {
            Console.WriteLine("4. Query para devolver todos los customers de la Región WA.");
            var customersLogic = new CustomersLogic();

            var query = from customer in customersLogic.GetAll()
                        where customer.Region == "WA"
                        select customer;
            List<Customers> result = query.ToList();

            Console.WriteLine("Consulta devuelta:");
            foreach (Customers customers in result)
            {
                Console.WriteLine(customers.ContactName);
            }

        }

        public static void Query5()
        {
            Console.WriteLine("5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789");
            var productLogic = new ProductLogic();

            var query = from product in productLogic.GetAll()
                        where product.ProductID == 789
                        select product;
            Products result = query.FirstOrDefault();

            if (result is null)
                Console.WriteLine("No se encontro elemento, Nulo");
            else
                Console.WriteLine($"Producto devuelto: {result.ProductName}");
        }

        public static void Query6()
        {
            Console.WriteLine("6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.");
            var customersLogic = new CustomersLogic();

            var queryMayuscula = from c in customersLogic.GetAll()
                                 select c.ContactName.ToUpper();

            var queryMinuscula = from c in customersLogic.GetAll()
                                 select c.ContactName.ToLower();

            Console.WriteLine("Customers en mayuscula");
            foreach (string nombres in queryMayuscula)
            {
                Console.WriteLine(nombres);
            }

            Console.WriteLine("**********************");

            Console.WriteLine("Customers en minuscula");
            foreach (string nombres in queryMinuscula)
            {
                Console.WriteLine(nombres);
            }
        }

        public static void Query7()
        {
            Console.WriteLine("7. Query para devolver Join entre Customers y Orders donde los customers sean de la \r\nRegión WA y la fecha de orden sea mayor a 1/1/1997.");
            var customersLogic = new CustomersLogic();
            var orderLogic = new OrderLogic();

            var result = customersLogic.GetAll()
            .Join(orderLogic.GetAll(), c => c.CustomerID, o => o.CustomerID, (c, o) => new { Customer = c, Order = o })
            .Where(co => co.Customer.Region == "WA" && co.Order.OrderDate > new DateTime(1997, 1, 1))
            .Select(co => new CustomerOrderDTO()
            {
                CustomerName = co.Customer.ContactName,
                OrderID = co.Order.OrderID,
                OrderDate = co.Order.OrderDate,
            })
            .ToList();

            Console.WriteLine("Consulta devuelta");

            foreach(CustomerOrderDTO customers in result)
            {
                Console.WriteLine($"CustomerName: {customers.CustomerName} | OrderID: {customers.OrderID} | OrderDate: {customers.OrderDate}");
            }

        }



    }
}
