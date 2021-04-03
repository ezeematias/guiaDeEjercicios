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
            cotizRespectoDolar = 0.925;
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
        public static explicit operator Dolar(Euro d)
        {
            return new Dolar(d.GetCantidad() / Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Euro d)
        {
            Dolar dolar = (Dolar)d;
            return new Pesos(dolar.GetCantidad() * Pesos.GetCotizacion());
        }
    }
}
