using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar = new Dolar(10);

            Euro euro = (Euro)dolar;
            Pesos pesos = (Pesos)dolar;


            Console.WriteLine("Dolar a Pesos {0}", pesos.GetCantidad());
            Console.WriteLine("Dolar a Euro {0}", euro.GetCantidad());
            Console.ReadLine();
        }
    }
}
