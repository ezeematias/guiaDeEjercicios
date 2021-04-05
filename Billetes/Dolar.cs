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
            return (!(d == (Dolar)p));
        }
        public static bool operator ==(Dolar d, Pesos p)
        {
            return (d == (Dolar)p);
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return (!(d1 == d2));

        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            if (!(d1 is null) && !(d2 is null) && d1.Equals(d2))
            {
                return true;
            }
            return false;

        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar dolarAux = (Dolar)e;
            dolarAux.cantidad -= d.GetCantidad();
            return dolarAux;
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar dolarAux = (Dolar)p;
            dolarAux.cantidad -= d.GetCantidad();
            return dolarAux;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar dolarAux = (Dolar)e;
            dolarAux.cantidad += d.GetCantidad();
            return dolarAux;
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar dolarAux = (Dolar)p;
            dolarAux.cantidad += d.GetCantidad();
            return dolarAux;
        }
    }
}
