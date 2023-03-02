using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesTransporte;

namespace labNetPractica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TransportePublico> transportes = new List<TransportePublico>();

            if (transportes != null)
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write("Ingrese cantidad de pasajeros del omnibus {0}: ", i);
                    string pasajerosIngresados = Console.ReadLine();
                    try
                    {
                        int pasajeros = int.Parse(pasajerosIngresados);
                       // Console.WriteLine("Pasajeros cargados con exito.");
                        transportes.Add(new Omnibus(pasajeros));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("No es valido el numero ingresado! Reingrese un numero valido.");
                        i--;
                    }
                }

                for (int i = 1; i <= 5; i++)
                {
                    Console.Write("Ingrese cantidad de pasajeros del taxi {0}: ", i);
                    string pasajerosIngresados = Console.ReadLine();
                    try
                    {
                        int pasajeros = int.Parse(pasajerosIngresados);
                       // Console.WriteLine("Pasajeros cargados con exito.");
                        transportes.Add(new Taxi(pasajeros));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("No es valido el numero ingresado! Reingrese un numero valido.");
                        i--;
                    }
                }

                int k = 1;
                int j = 1;

                foreach (var transporte in transportes)
                {                 
                    if (transporte is Omnibus)
                    {
                        Console.WriteLine($"Omnibus {k}: {transporte.Pasajeros} pasajeros.");
                        k++;
                    }
                    if (transporte is Taxi)//creo que podria ir un else aca pero creo queda mas claro de esta forma
                    {
                        Console.WriteLine($"Taxi {j}: {transporte.Pasajeros} pasajeros.");
                        j++;
                    }

                    //lo hice con dos contadores de modo que si la lista se desordena, de todas formas enumere bien
                    //podria haber hecho una propiedad para los transportes con el numero pero preferi respetar el
                    //modelo UML
                }
            }
            else
            {
                Console.WriteLine("No se pudo crear la lista de transportes.");
            }

            Console.ReadKey();
        }
    }
}
