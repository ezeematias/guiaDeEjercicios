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
        private static double cotizRespectoDolar;
        static Euro() 
        {
            cotizRespectoDolar = 1.08;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {            
            cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }
    }
}
