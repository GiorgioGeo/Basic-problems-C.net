using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sa se citeasca un numar de 3 cifre sa se afiseze inversul lui
            int n;
            Console.WriteLine("Introduceti numarul :");
            n = Int32.Parse(Console.ReadLine());
            int cifra1 = n % 10;
            int cifra2 = (n / 10) % 10;
            int cifra3 = n / 100;
            int numarInvers = cifra1 * 100 + cifra2 * 10 + cifra3;
            Console.WriteLine("Numarul scris invers este :" + numarInvers);
            Console.ReadKey();

        }
    }
}
