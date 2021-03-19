using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {

            int number;
            int primeNumber = 0;
            int bufferPrime = 1;
            string bufferNumber;

            do
            {
                Console.WriteLine("Ingrese el número mayor a 0 para averiguar los números primos anteriores.");
                bufferNumber = Console.ReadLine();
                number = int.Parse(bufferNumber);
                if (number < 1)
                {
                    Console.WriteLine("¡ERROR!");
                }
                else
                {
                    Console.WriteLine("Los números primos son:");
                    while (bufferPrime <= number)
                    {
                        for (int i = 1; i <= bufferPrime; i++)
                        {
                            if (bufferPrime % i == 0)
                            {
                                primeNumber++;
                            }
                        }
                        if (primeNumber == 2)
                        {                            
                            Console.WriteLine(bufferPrime);
                        }
                        primeNumber = 0;
                        bufferPrime++;
                    }
                }
            } while (number < 1);
            Console.ReadKey();
        }
    }
}
