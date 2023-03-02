using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTransporte
{
    public class Omnibus : TransportePublico
    {
        public Omnibus(int cantidadPasajeros) : base(cantidadPasajeros)
        {
        }

        public override string Avanzar()
        {
            return base.Avanzar()+" Soy un omnibus.";
        }
        public override string Detenerse()
        {
            return base.Avanzar() + " Soy un omnibus.";
        }

        public override string ToString()
        {
            return $"Soy un omnibus." + base.ToString();
        }
    }
}
