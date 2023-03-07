using labNetPractica2.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2
{
    public class Logica
    {
        public static decimal DividirDosDecimales(decimal dividendo, decimal divisor, Action<string> delegado)
        {
            try
            {
                return dividendo / divisor;
            }
            catch (DivideByZeroException)
            {
                try
                {
                    CustomExceptions.ThrowCustomException();
                }
                catch(Exception ex)
                {
                    delegado.Invoke(ex.Message);
                }
                return 0;
            }
            finally
            {
                if(divisor != 0)
                    delegado.Invoke($"Resultado: {dividendo}/{divisor}: {dividendo / divisor}");
            }
        }
    }
}
