using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolar
    {
        private double cantidad;
        private double cotizRespectoDolar;

        private Dolar() : this(1)
        {

        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            this.cantidad = cantidad;
            this.cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Euro(Dolar d)
        {
            return d.cotizRespectoDolar;
        }
    }
}
