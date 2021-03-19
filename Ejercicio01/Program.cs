using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = new int [5];
            int numberMax = 0;
            int numberMin = 0;
            int average = 0;
            string bufferNumber;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el " + (i + 1) + "º número");
                bufferNumber = Console.ReadLine();
                numbers[i] = int.Parse(bufferNumber);
                average += numbers[i];
                if (i == 0 || numberMax < numbers[i])
                {
                    numberMax = numbers[i];
                }
                if (i == 0 || numberMin > numbers[i])
                {
                    numberMin = numbers[i];
                }
            }
            Console.WriteLine("El mayor número ingresado es " + numberMax);
            Console.WriteLine("El menor número ingresado es " + numberMin);
            Console.WriteLine("El promedio de los números es " + average/5);
           
            foreach (int number in numbers)
            {
                Console.WriteLine("Consola.Number: " + number);
            }
            Console.ReadKey();

        }
    }
}
