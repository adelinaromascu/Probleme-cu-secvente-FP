using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_11
{
    // 21 34 56
    //12 43 65
    //1 2 3 4 
    class Program
    {   //11
        //Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 

        //23
        //23
        //3 * 10  +
        static int inversareNr(int n)
        {
            int invers = 0, rest;
            
            while(n != 0)
            {
                rest = n % 10;
                invers = invers * 10 + rest;
                n /= 10;
            }
            return invers;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Inversare 43: " + inversareNr(43));
            Console.WriteLine("Introdu n: ");
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            int nr;

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Introdu elementul:" + i + " ");
                nr = int.Parse(Console.ReadLine());
                s = s + inversareNr(nr);
            }
            Console.WriteLine("Suma elementelor inverse: " + s);
        }
    }
}
