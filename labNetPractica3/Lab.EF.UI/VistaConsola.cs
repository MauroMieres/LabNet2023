using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
{
    public class VistaConsola
    {
        public static int ShowMainMenu()
        {
            int option;
            while (true)
            {
                Console.WriteLine("Elija una opcion:");
                Console.WriteLine("1. Modificar registros.");
                Console.WriteLine("2. Borrar registros.");
                Console.WriteLine("3. Agregar registros.");
                Console.WriteLine("10. Salir del programa.");

                var inputOption = Console.ReadLine();

                if (int.TryParse(inputOption, out option))
                {
                    if (option == 1 || option == 2 || option == 3 || option == 10)
                        return option;
                }
                Console.WriteLine("ERROR. Ingrese una opcion valida.");
            }
        }

        public static void UpdateMenu()
        {
            int option;
            while (true)
            {
                Console.WriteLine("Elige una tabla para modificar");
                Console.WriteLine("1. Categories");
                Console.WriteLine("2. Supplies");
                Console.WriteLine("10. Volver al menu principal.");
                var inputOption = Console.ReadLine();
               
                if (int.TryParse(inputOption, out option))
                {
                    if (option == 1 || option == 2 || option == 10)
                        break;
                }
                Console.WriteLine("ERROR. Ingrese una opcion valida.");
            }

            switch (option)
            {
                case 1://logica suppliersList
                    UpdateCategoriesUI();
                    break;

                case 2://logica suppliersList
                    UpdateSuppliesUI();
                    break;

                case 10:
                    return;
                default:
                    return;
            }     
        }

        public static void UpdateCategoriesUI()
        {
            Console.WriteLine($"Modificar categorias:");

            IABMLogic<Categories> categoriesLogic = new CategoriesLogic();

            var categories = categoriesLogic.GetAll();

            foreach (var category in categories)
            {
                Console.WriteLine($"ID: {category.CategoryID} - {category.CategoryName}");
            }

            int id;
            Categories entity = new Categories();

            while (true)
            {
                Console.WriteLine("Ingrese ID del producto que desea modificar:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out id))
                {
                    entity = categoriesLogic.GetById(id);

                    if (entity != null)
                    {
                        id = entity.CategoryID;
                        break;
                    }
                }
                Console.WriteLine("ERROR. Ingrese un ID existente en el sistema.");
            }

            Console.WriteLine($"ID ingresado: {id}");
            Console.WriteLine($"Objeto que quieres modificar:\nID: {entity.CategoryID} - {entity.CategoryName}");
            Console.WriteLine("Ingrese nuevo nombre para la categoria");

            string categoryUpdateName = Console.ReadLine();

            entity.CategoryName = categoryUpdateName;

            categoriesLogic.Update(entity);

            foreach (var category in categories)
            {
                Console.WriteLine($"ID: {category.CategoryID} - {category.CategoryName}");
            }
        }

        public static void UpdateSuppliesUI()
        {
            Console.WriteLine($"Modificar suppliers:");

            IABMLogic<Suppliers> suppliersLogic = new SuppliersLogic();

            var suppliersList = suppliersLogic.GetAll();

            foreach (var supplier in suppliersList)
            {
                Console.WriteLine($"ID: {supplier.SupplierID} - {supplier.ContactName}");
            }

            int id;
            Suppliers entity = new Suppliers();

            while (true)
            {
                Console.WriteLine("Ingrese ID del supplier que desea modificar:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out id))
                {
                    entity = suppliersLogic.GetById(id);

                    if (entity != null)
                    {
                        id = entity.SupplierID;
                        break;
                    }
                }
                Console.WriteLine("ERROR. Ingrese un ID existente en el sistema.");
            }

            Console.WriteLine($"ID ingresado: {id}");
            Console.WriteLine($"Objeto que quieres modificar:\nID: {entity.SupplierID} - {entity.ContactName}");
            Console.WriteLine("Ingrese nuevo nombre para el supplier");

            string categoryUpdateName = Console.ReadLine();

            entity.ContactName = categoryUpdateName;

            suppliersLogic.Update(entity);

            foreach (var category in suppliersList)
            {
                Console.WriteLine($"ID: {category.SupplierID} - {category.ContactName}");
            }
        }

    }
}
