using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sa se citeasca un numar N sa se afiseze urmatorul numar divizibil cu 10 dupa el
            int n;
            Console.WriteLine("Introduceti numarul :");
            n = Int32.Parse(Console.ReadLine());
          
            while( n% 10 != 0)
            {
                n++;
                
                
            }
            Console.WriteLine("Numarul div cu 10 este :" +  n );
            Console.ReadKey();
        }   
    }
}
