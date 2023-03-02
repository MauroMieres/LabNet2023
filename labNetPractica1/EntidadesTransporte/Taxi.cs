using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTransporte
{
    public class Taxi : TransportePublico
    {
        public Taxi(int cantidadPasajeros) : base(cantidadPasajeros)
        {
        }
        public override string Avanzar()
        {
            return base.Avanzar()+" Soy un taxi.";
        }

        public override string Detenerse()
        {
            return base.Avanzar() + " Soy un taxi.";
        }

        public override string ToString()
        {
            return $"Soy un taxi."+base.ToString();
        }
    }
}
