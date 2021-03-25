using Biblioteca;
using System;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            long suma;
            Sumador s1 = new Sumador();
            suma = s1.Sumar(10, 20);

            Console.WriteLine("SUMADOR S1 " + s1 + "\nRESULTADO SUMA " + suma + "\nCANTIDAD SUMAS " + s1.cantidadSumas);

            Console.ReadLine();

        }

    }
}
