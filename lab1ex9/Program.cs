using System;

namespace lab1ex9
{
    /*Scrieti un program care interschimba valoarea a doua variabile intregi.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acest program va interschimba valoare a 2 numere introduse. \n");

            Console.WriteLine("Introduceti numarul 1(X):");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul 2 (Y):");
            var y = int.Parse(Console.ReadLine());

            var z = x;
            x = y;
            y = z;

            Console.WriteLine("Valori interschimbate \n");
            Console.WriteLine("x: " + x  +"\n");
            Console.WriteLine("y: " + y + "\n");
        }
    }
}
