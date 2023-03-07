using labNetPractica2.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2
{
    public class Logic
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
                    ThrowCustomException();
                }
                catch(Exception ex)
                {
                    if(delegado != null)
                    delegado.Invoke(ex.Message);
                }
                return 0;
            }
            finally
            {
                if(divisor != 0)
                {
                    if (delegado != null)
                        delegado.Invoke($"Resultado: {dividendo}/{divisor}: {dividendo / divisor}");
                }
                    
            }
        }

        public static void ThrowCustomException()
        {
            throw new CustomExceptions();
        }

        public static void ThrowException()
        {
            throw new Exception();
        }
    }


}
