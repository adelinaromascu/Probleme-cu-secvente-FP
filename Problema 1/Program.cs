using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    class Program
    {  
        //Problema 1
        //Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 

        static int pare(int[] v)
        {
            int nrPare = 0;

            for(int i = 0;i < v.Length; i++)
            {
                if(v[i]%2 == 0)
                {
                    nrPare++;
                }
            }
            return nrPare;
        }

        static void Main(string[] args)
        {  
            Console.WriteLine("Introdu n:");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introdu numerele: ");

            for(int i = 0; i < n; i++)
            {
                Console.Write("V[" + i + "]:");
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
                 
            }
            Console.WriteLine();
            Console.WriteLine("Numere pare: " + pare(v));
        }
    }
}
