using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sa se citeasca un numar N, sa se afiseze media aritmetica a cifrelor lui
            int n;
            Console.WriteLine("Introduceti numarul :");
            n = Int32.Parse(Console.ReadLine());

            int cifra = 0;
            int nrCifre = 0;
            int sumaCifre = 0;
            while(n != 0)
            {
                cifra = n % 10;
                sumaCifre += cifra;
                n = n / 10;

                nrCifre++;

            }
            Console.WriteLine("Media aritmetica a cifrelor numarului este : " + (sumaCifre / nrCifre));
            Console.ReadKey();
        }
    }
}
