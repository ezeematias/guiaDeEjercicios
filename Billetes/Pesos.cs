using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Pesos
    {
        private double cantidad;
        private double cotizRespectoDolar;
        private Pesos() : this(1)
        {

        }
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            this.cantidad = cantidad;
            this.cotizRespectoDolar = cotizacion;
        }
    }
}
