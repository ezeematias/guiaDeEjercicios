using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string bufferNumber;
            Console.WriteLine("Ingrese su número: ");
            bufferNumber = Console.ReadLine();
            number = int.Parse(bufferNumber);
            Console.WriteLine("El cuadrado de " + number + " es: " + Math.Pow(number, 2));
            Console.WriteLine("El cubo de " + number + " es: " + Math.Pow(number, 3));
            Console.ReadKey();
        }
    }
}
