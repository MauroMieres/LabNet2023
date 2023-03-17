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
            VistaQuerys.Query1();
            PressKey();
            VistaQuerys.Query2();
            PressKey();
            VistaQuerys.Query3();
            PressKey();
            VistaQuerys.Query4();
            PressKey();
            VistaQuerys.Query5();
            PressKey();
            VistaQuerys.Query6();
            PressKey();
            VistaQuerys.Query7();
            Console.ReadLine();
        }

        public static void PressKey()
        {
            Console.WriteLine("Presione una tecla para continuar con la siguiente query.");
            Console.ReadKey();
            Console.WriteLine("*********************************************************");
        }
    }
}
