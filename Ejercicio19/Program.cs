using Biblioteca;
using System;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            long suma;
            string titulo;
            Sumador s1 = new Sumador();
            Sumador s2 = new Sumador(1);
            Console.WriteLine(s1.Sumar(10, 20));
            Console.WriteLine(s2.Sumar("Holis"," 20"));
            Console.WriteLine(s2 + s1);
            Console.WriteLine(s1 | s2);    


            Console.ReadLine();

        }

    }
}
