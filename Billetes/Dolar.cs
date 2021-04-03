using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar

    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar() 
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        { 
           cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.GetCantidad() * Euro.GetCotizacion());                      
        }

        public static explicit operator Pesos(Dolar d)
        {
           return new Pesos(d.GetCantidad() * Pesos.GetCotizacion());            
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static bool operator !=(Dolar d, Euro e)
        {            
            return (!(d == (Dolar)e));
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            return (d == (Dolar)e);
        }
        public static bool operator !=(Dolar d, Pesos p)
        {
            if (d != p)
            {

            }
            return false;
        }
        public static bool operator ==(Dolar d, Pesos p)
        {
            if (d == p)
            {

            }
            return false;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            if (d1 != d2)
            {

            }
            return false;
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            if (d1 == d2)
            {
                return true;
            }
            return false;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return d - e;
        }

    }
}
