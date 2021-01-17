using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6
{
    class Program
    {
        // Problema 6
        //Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 

        static int[] citireSecventa()
        {
            Console.WriteLine("Introdu n:");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introdu numerele: ");

            for (int i = 0; i < n; i++)
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

            return v;
        }

        static bool crescator(int[] v)
        {
            bool secvCrescatoare = false;
         
            for(int i = 0; i < v.Length-1; i++)
            {
                if(v[i] <= v[i+1])
                {
                    secvCrescatoare = true;
                }
            }
            return secvCrescatoare;
        }


        static void Main(string[] args)
        {
            int[] v = citireSecventa();

            if (crescator(v))
            {
                Console.WriteLine("Secventa crescatoare :)");
            }else
            {
                Console.WriteLine("Secventa descrescatoare :(");
            }
        }
    }
}
