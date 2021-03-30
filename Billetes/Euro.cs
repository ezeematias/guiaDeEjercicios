using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private double cotizRespectoDolar;
        private Euro() : this(1)
        {

        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            this.cantidad = cantidad;
            this.cotizRespectoDolar = cotizacion;
        }
    }
}
