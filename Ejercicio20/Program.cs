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

            //Probando la conversión
             
            Euro euro = (Euro)dolar;
            Pesos pesos = (Pesos)dolar;  


            Console.WriteLine("Dolar a Pesos {0}", pesos.GetCantidad());
            Console.WriteLine("Dolar a Euro {0}", euro.GetCantidad());
            

            Euro euro2 = new Euro(10);
            Pesos pesos2 = new Pesos(660);
            Dolar dolarPesos = (Dolar)pesos2;

            Console.WriteLine("Dolar a Pesos {0}", dolarPesos.GetCantidad());


            if (dolar == dolarPesos)
            {
                Console.WriteLine("Es igual DOLAR - PESOS\n");

            }
            else if (dolar != pesos2)
            {
                Console.WriteLine("NO es igual, DOLAR - PESOS\n");

            }

            if (dolar == euro2)
            {
                Console.WriteLine("Es igual DOLAR - EURO\n");

            }
            else if (dolar != euro2)
            {
                Console.WriteLine("NO es igual, DOLAR - EURO\n");

            }




            Console.ReadLine();
        }
    }
}
