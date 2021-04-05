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

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.GetCantidad() / Pesos.GetCotizacion());
        }

        public static explicit operator Euro(Pesos p)
        {
            Dolar dolar = (Dolar)p;
            return new Euro(dolar.GetCantidad() * Euro.GetCotizacion());
        }



    }
}
