using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    class Program
    {
        //Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numar a. 
        //Se considera ca primul element din secventa este pe pozitia zero. 
        //Daca numarul nu se afla in secventa raspunsul va fi -1. 

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

        static int poz(int[] v,int a)
        {
            int poz = -1;

            for(int i = 0; i < v.Length; i++)
            {
                if (v[i] == a)
                {
                    poz = i;   
                }
            }

            return poz;
        }

        static void Main(string[] args)
        {
            int[] v = citireSecventa();
            Console.WriteLine("Introdu a: ");
            int a = int.Parse(Console.ReadLine());

            if(poz(v,a) == -1)
            {
                Console.WriteLine("Elementul " + a + " nu a fost gasit.");
            }
            else
            {
                Console.WriteLine("Pozitia elementului " + a + " este: " + poz(v, a));
            }



        }
    }
}
