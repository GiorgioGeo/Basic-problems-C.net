using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sa se citeasca un numar N, sa se afiseze inversul lui
            int n;
            Console.WriteLine("Introduceti numarul :");
            n = Int32.Parse(Console.ReadLine());
           int cifra = 0;
            int nrInversat = 0;
            while(n != 0)
            {
                cifra = n % 10;
                n = n / 10;
                nrInversat = nrInversat * 10 + cifra;

            }
            Console.WriteLine("Numarul scris invers este :" + nrInversat);
            Console.ReadKey();
        }
    }
}
