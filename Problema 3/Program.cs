using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{   //Problema 3
    //Calculati suma si produsul numerelor de la 1 la n. 
    class Program
    {
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

        static int suma(int[] v)
        { int s = 0;
            for(int i = 0;i < v.Length; i++)
            {
                s = s + v[i];

            }
            return s;
        }   
        
        static int produs(int[] v)
        { int p = 1;
            for(int i = 0;i < v.Length; i++)
            {
                p = p * v[i];

            }
            return p;
        }

        static void Main(string[] args)
        {
            int[] v = citireSecventa();

            Console.WriteLine("Suma de la 1 la n: " + suma(v));
            Console.WriteLine("Produsul de la 1 la n: " + produs(v));
        }
    }
}
