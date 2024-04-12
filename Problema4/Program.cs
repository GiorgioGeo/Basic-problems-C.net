using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sa se citeasca un numar N, sa se inlocuiasca toate cifrele pare cu 0 si toate cifrele impare 1
            // (Numarul citit va incepe mereu cu o cifra impara)
            int n;
            Console.WriteLine("Introduceti numarul :");
            n = Int32.Parse(Console.ReadLine());
            int cifra;
            int p = 1;
            int nr = 0;
            while (n != 0)
            {
                cifra = n % 10;
                
                if (cifra % 2 != 0)
                {
                    nr = p + nr;
                }
                p = p * 10;
                n = n / 10;
               
            }
            Console.WriteLine(nr);
            Console.ReadKey();
        }
    }
}
