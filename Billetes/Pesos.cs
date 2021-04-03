using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;
        static Pesos() 
        {
           cotizRespectoDolar = 66;
        }
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
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
