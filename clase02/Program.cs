using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;



namespace clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 0;
            int minNumber = 0;
            int averageNumber = 0;
            int numberUser;
            string value;
            bool correctly;
            Console.WriteLine("Vamos a ingresar 10 números entre -100 y 100\n");
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese el " + (i + 1) + "º número");
                    value = Console.ReadLine();
                    correctly = true;
                    if (int.TryParse(value, out numberUser))
                    {
                        correctly = true;  
                        if (Validacion.Validar(numberUser, -100, 100) && i == 0 ||numberUser > maxNumber)
                        {
                            maxNumber = numberUser;
                        }
                        if (Validacion.Validar(numberUser, -100, 100) && i == 0 ||numberUser < minNumber)
                        {
                            minNumber = numberUser;
                        }
                        averageNumber += numberUser;
                    }
                    else
                    {
                        correctly = false;
                    }
                } while (correctly == false);
            }
            Console.WriteLine("El número máximo ingresado fue: " + maxNumber);
            Console.WriteLine("El número mínimo ingresado fue: " + minNumber);
            Console.WriteLine("El promedio de los números ingresados es: " + averageNumber / 10);
            Console.ReadLine();
        }
    }
}
