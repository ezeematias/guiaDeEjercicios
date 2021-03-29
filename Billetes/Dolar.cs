using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    internal class Dolar

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
            return (Euro)d;
        }

        public static explicit operator Pesos(Dolar d)
        {
            return (Pesos)d;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public double GetCotizacion()
        {
            return this.cotizRespectoDolar;
        }

        public static implicit operator Dolar(double d)
        {
            return (Dolar)d;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            if (d != e)
            {

            }
            return true;
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            if (d == e)
            {

            }
            return false;
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
