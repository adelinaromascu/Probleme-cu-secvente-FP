using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_7
{
    class Program
    {
     //problema 7
     //Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
       
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

        static void Main(string[] args)
        {
            int[] v = citireSecventa();
            int min = v[0], max = v[0];

            for(int i = 0; i < v.Length; i++)
            {
                if (v[i]<min)
                {
                    min = v[i];
                }

                if (v[i] > max)
                {
                    max = v[i];
                }
            }

            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
        }
    }
}
