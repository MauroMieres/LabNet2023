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
                case 1://logica category
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

        public static void DeleteMenu()
        {
            int option;
            while (true)
            {
                Console.WriteLine("Elige la tabla de donde desea borrar un registro:");
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
                case 1://logica borrar category
                    DeleteCategory();
                    break;

                case 2://logica borrar supplier
                    DeleteSupplier();
                    break;

                case 10:
                    return;
                default:
                    return;
            }
        }

        public static void InsertMenu()
        {
            int option;
            while (true)
            {
                Console.WriteLine("Elige una tabla para agregar un nuevo registro.");
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
                case 1://logica category
                    InsertCategoryUI();
                    break;

                case 2://logica suppliersList
                    InsertSupplierUI();
                    break;

                case 10:
                    return;
                default:
                    return;
            }
        }

        public static void DeleteCategory()
        {
            Console.WriteLine("*** Borrar un registro de la tabla categories ***");

            IABMLogic<Categories> categoriesLogic = new CategoriesLogic();
            var categories = categoriesLogic.GetAll();
            foreach (var category in categories)
            {
                Console.WriteLine($"ID: {category.CategoryID} - {category.CategoryName}");
            } 
            int idExistente;
            var entity = new Categories();
            while (true)
            {
                Console.WriteLine("Ingrese ID del producto que desea borrar:");
                string input = Console.ReadLine();


                if (int.TryParse(input, out idExistente))
                {
                    entity = categoriesLogic.GetById(idExistente);

                    if (entity != null)
                    {
                        Console.WriteLine("** ID encontrado en el sistema ***");
                        Console.WriteLine($"Registro encontrado: \n {entity.CategoryID} - {entity.CategoryName}");
                        break;
                    }
                }
                Console.WriteLine("ERROR. Ingrese un ID existente en el sistema.");
            }

            while (true)
            {
                Console.WriteLine($"Confirma que quiere borrar el registro? ");
                Console.WriteLine("S/N");
                string respuesta = Console.ReadLine().ToUpper().Trim();
                if (respuesta == "S")
                    break;
                else
                {
                    Console.WriteLine("Cancela el borrado del registro?");
                    Console.WriteLine("S/N");
                    try
                    {
                        string cancelaRegistro = Console.ReadLine();
                        if (ValidationsUI.ValidateYesOrNo(cancelaRegistro))
                            return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            try
            {
                categoriesLogic.Delete(entity);
                Console.WriteLine("Borrado del registro exitoso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DeleteSupplier()
        {
            Console.WriteLine("*** Borrar un registro de la tabla suplliers ***");

            IABMLogic<Suppliers> suppliersLogic = new SuppliersLogic();
            var suppliers = suppliersLogic.GetAll();
            foreach (var supplier in suppliers)
            {
                Console.WriteLine($"ID: {supplier.SupplierID} - {supplier.CompanyName}");
            }
            int idExistente;
            var entity = new Suppliers();
            while (true)
            {
                Console.WriteLine("Ingrese ID del supplier que desea borrar:");
                string input = Console.ReadLine();


                if (int.TryParse(input, out idExistente))
                {
                    entity = suppliersLogic.GetById(idExistente);

                    if (entity != null)
                    {
                        Console.WriteLine("** ID encontrado en el sistema ***");
                        Console.WriteLine($"Registro encontrado: \n {entity.SupplierID} - {entity.CompanyName}");
                        break;
                    }
                }
                Console.WriteLine("ERROR. Ingrese un ID existente en el sistema.");
            }

            while (true)
            {
                Console.WriteLine($"Confirma que quiere borrar el registro? ");
                Console.WriteLine("S/N");
                string respuesta = Console.ReadLine().ToUpper().Trim();
                if (respuesta == "S")
                    break;
                else
                {
                    Console.WriteLine("Cancela el borrado del registro?");
                    Console.WriteLine("S/N");
                    try
                    {
                        string cancelaRegistro = Console.ReadLine();
                        if (ValidationsUI.ValidateYesOrNo(cancelaRegistro))
                            return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            try
            {
                suppliersLogic.Delete(entity);
                Console.WriteLine("Borrado del registro exitoso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void UpdateCategoriesUI()
        {
            Console.WriteLine($"*** Modificar categorias ***");

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

        public static void InsertCategoryUI()
        {
            Console.WriteLine("*** Agregar un Category ***");

            string nombreCategory;
            while (true)
            {
                Console.Write("Ingrese nombre del category:");
                nombreCategory = Console.ReadLine();
                if (ValidationsUI.ValidateLettersAndSpaces(nombreCategory))
                    break;
                Console.WriteLine("Ingrese un nombre valido! Solo caracteres y espacios!");
            }

            CategoriesLogic categoriesLogic = new CategoriesLogic();
            try
            {
                var newCategory = new Categories();
                newCategory.CategoryName = nombreCategory;

                while (true)
                {
                    Console.WriteLine($"Confirma que quiere agregar el registro nuevo? \n Nueva categoria: {nombreCategory}.");
                    Console.WriteLine("S/N");
                    string respuesta = Console.ReadLine().ToUpper().Trim();
                    if (respuesta == "S")
                        break;
                    else
                    {
                        Console.WriteLine("Cancela el ingreso del nuevo registro?");
                        Console.WriteLine("S/N");
                        try
                        {
                            string cancelaRegistro = Console.ReadLine();
                            if (ValidationsUI.ValidateYesOrNo(cancelaRegistro))
                                return;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }

                try
                {
                    categoriesLogic.Insert(newCategory);
                    Console.WriteLine("Categoria agregada exitosamente!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                var categories = categoriesLogic.GetAll();

                Console.WriteLine("*** Lista de categories ***");
                foreach (var category in categories)
                {
                    Console.WriteLine($"ID: {category.CategoryID} - {category.CategoryName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void InsertSupplierUI()
        {
            Console.WriteLine("*** Agregar un supplier ***");

            string nombreSupplier;
            while (true)
            {
                Console.Write("Ingrese nombre del nuevo supplier:");
                nombreSupplier = Console.ReadLine();
                if (ValidationsUI.ValidateLettersAndSpaces(nombreSupplier))
                    break;
                Console.WriteLine("Ingrese un nombre valido! Solo caracteres y espacios!");
            }

            SuppliersLogic categoriesLogic = new SuppliersLogic();
            try
            {
                var newCategory = new Suppliers();
                newCategory.CompanyName = nombreSupplier;

                while (true)
                {
                    Console.WriteLine($"Confirma que quiere agregar el registro nuevo? \n Nuevo supplier: {nombreSupplier}.");
                    Console.WriteLine("S/N");
                    string respuesta = Console.ReadLine().ToUpper().Trim();
                    if (respuesta == "S")
                        break;
                    else
                    {
                        Console.WriteLine("Cancela el ingreso del nuevo registro?");
                        Console.WriteLine("S/N");
                        try
                        {
                            string cancelaRegistro = Console.ReadLine();
                            if (ValidationsUI.ValidateYesOrNo(cancelaRegistro))
                                return;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }

                try
                {
                    categoriesLogic.Insert(newCategory);
                    Console.WriteLine("Supplier agregado exitosamente!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                var categories = categoriesLogic.GetAll();

                Console.WriteLine("*** Lista de suppliers ***");
                foreach (var category in categories)
                {
                    Console.WriteLine($"ID: {category.SupplierID} - {category.CompanyName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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

            string supplierUpdateName = Console.ReadLine();

            entity.ContactName = supplierUpdateName;

            suppliersLogic.Update(entity);

            foreach (var supplier in suppliersList)
            {
                Console.WriteLine($"ID: {supplier.SupplierID} - {supplier.ContactName}");
            }
        }

    }
}
