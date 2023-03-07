using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.ExtensionMethods
{
    public static class IntegerExtensions
    {
        public static decimal DividirPorCero(this decimal dividendo, Action<string> delegado)
        {
            try
            {
                return dividendo / 0;
            }
            catch (DivideByZeroException)
            {
                delegado.Invoke("No se puede dividir por cero!");
                return 0;
            }
            finally
            {
                delegado.Invoke("Fin de la operacion.");
            }
        }
    }
}
