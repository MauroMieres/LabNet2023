using labNetPractica2.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2
{
    internal class Program
    {
        public static void ImprimirConsola(string texto)
        {
            Console.WriteLine(texto);
        }

        static void Main(string[] args)
        {
            int intentos1 = 2;
            Console.WriteLine("1) Ingresar un numero y dividirlo por cero, controlar la excepcion.");
            while (intentos1 >= 0)
            {
                try
                {               
                    Console.Write("Ingrese un dividendo: ");
                    string numeroIngresado = Console.ReadLine();
                    decimal numero = decimal.Parse(numeroIngresado);
                    numero.DividirPorCero(ImprimirConsola);
                    break;
                }
                catch (FormatException)
                {
                    if(intentos1!=0)
                    Console.WriteLine($"Ingrese un divisor valido! Intentos restantes: {intentos1}.");
                    intentos1--;
                }
                if(intentos1 == -1)
                {
                    Console.WriteLine(  "Te quedaste sin intentos1, se continuara con el siguiente punto");
                    break;
                }
            }
            Console.WriteLine("------------------------------------------------------------");      
            int intentos2 = 2;
            Console.WriteLine("2) Realizar un método que permita ingresar 2 números (dividendo y divisor) y realice la división de los mismos ...");
            decimal dividendo = default;
            decimal divisor;
            while (intentos2 >= 0)
            {
                try

                {
                    Console.Write("Ingrese un dividendo: ");
                    string dividendoIngresado = Console.ReadLine();

                    dividendo = decimal.Parse(dividendoIngresado);
                    if (dividendo == 0)
                    {
                        Console.WriteLine($"0 dividido cualquier numero dara cero, intente con otro numero. Intentos restantes: {intentos2}.");
                        intentos2--;
                        continue;
                    }
                    break;
                }
                catch (FormatException)
                {
                    if (intentos2 != 0)
                        Console.WriteLine($"Seguro Ingreso una letra o no ingreso nada!”. Intentos restantes: {intentos2}.");
                    intentos2--;
                }
                if (intentos2 == -1)
                {
                    Console.WriteLine("Te quedaste sin intentos, se continuara con el siguiente punto");
                    break;
                }   
            }

            if(intentos2 != -1)
            {
                int intentos3 = 2;
                while (intentos3 >= 0)
                {
                    try
                    {
                        Console.Write("Ingrese un divisor: ");
                        string divisorIngresado = Console.ReadLine();
                        divisor = decimal.Parse(divisorIngresado);
                        if(dividendo != default)
                        Logica.DividirDosDecimales(dividendo, divisor, ImprimirConsola);
                        break;
                    }
                    catch (FormatException)
                    {
                        if (intentos3 != 0)
                            Console.WriteLine($"Seguro Ingreso una letra o no ingreso nada!”. Intentos restantes: {intentos3}.");
                        intentos3--;
                    }
                    if (intentos3 == -1)
                    {
                        Console.WriteLine("Te quedaste sin intentos, se continuara con el siguiente punto");
                        break;
                    }
                }
            }          
            Console.ReadKey();
        }

        

    }
}
