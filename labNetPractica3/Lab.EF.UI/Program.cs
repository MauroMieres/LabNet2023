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
            //esto solo tiene que aparecer en el branch4

            string answer = "s";
            do
            {
                switch (VistaConsola.ShowMainMenu())
                {
                    case 1://modificar
                        VistaConsola.UpdateMenu();
                        break;

                    case 2://borrar
                        VistaConsola.DeleteMenu();
                        break;

                    case 3://agregar
                        VistaConsola.InsertMenu();
                        break;

                    case 10://salir
                        answer = "n";
                        Console.WriteLine("Gracias por usar el programa!");
                        break;

                    default:
                        return;
                }
            } while (answer == "s");

            Console.ReadLine();
        }
    }
}
