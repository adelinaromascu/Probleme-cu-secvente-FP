using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5
{
    class Program
    {//problema 5
     //Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.
     //Se considera ca primul element din secventa este pe pozitia 0.
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

        static int nrPozitii(int[] v)
        {
            int nrPoz = 0;

            for(int i = 0; i < v.Length; i++)
            {
                if(v[i] == i)
                {
                    nrPoz++;
                }
            }

            return nrPoz;
        }

        static void Main(string[] args)
        {
            int[] v = citireSecventa();

            Console.WriteLine("Nr de elemente care au acelasi indice din secventa: " + nrPozitii(v));

        }
    }
}
