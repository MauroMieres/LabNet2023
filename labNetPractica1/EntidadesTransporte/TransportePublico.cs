using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTransporte
{
    public abstract class TransportePublico
    {
        private int pasajeros;

        public int Pasajeros { get => pasajeros; set => pasajeros = value; }

        public virtual string Avanzar()
        {
            return $"El vehiculo avanza.";
        }

        public virtual string Detenerse()
        {
            return $"El vehiculo se detiene.";
        }

        public override string ToString()
        {
            return $" Llevo {this.pasajeros} pasajeros.";
        }

        public TransportePublico(int cantidadPasajeros)
        {
            this.pasajeros = cantidadPasajeros;
        }
    }
}
