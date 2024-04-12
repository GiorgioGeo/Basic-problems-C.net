using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Sa se citeasca un numar N,
            // sa se afiseze diferenta dintre cea mai din dreapta cifra para si cea mai din stanga cifra impara
            int n;
            Console.WriteLine("Introduceti numarul :");
            n = Int32.Parse(Console.ReadLine());
            int cifra = 0;
            int cifraPara = 0;
            int cifraImpara = 0;
            int k = n;
            int cifra2;
            while (n != 0 )
            {
                cifra = n % 10;
                if(cifra % 2 == 0)
                {
                    cifraPara = cifra;
                    break;
                }
                n = n / 10;
            }

            Console.WriteLine("Cea mai din  dreapta cifra para este :" + cifraPara);
            while( k != 0 )
            {
                cifra2= k % 10;
                if (cifra2 % 2 != 0 )
                {
                    cifraImpara =  cifra2;
                }
                k = k / 10;
            }
            Console.WriteLine("Cea mai din stanga cifra impara este : " + cifraImpara);
            if (cifraPara > cifraImpara)
            {
                Console.WriteLine("Diferenta dintre cele doua cifre este : " + (cifraPara - cifraImpara));
            }
            else
            {
                Console.WriteLine("Diferenta dintre cele doua cifre este : " + (cifraImpara - cifraPara));
            }
            Console.ReadKey();
        }
    }
}
