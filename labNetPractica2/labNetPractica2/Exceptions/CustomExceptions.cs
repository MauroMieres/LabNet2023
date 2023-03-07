using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2.Exceptions
{
    public class CustomExceptions : Exception
    {
        public CustomExceptions() : base ("Solo Chuck Norris puede dividir por cero!") { }

        public static void ThrowCustomException()
        {
            throw new CustomExceptions();
        }
    }
}
