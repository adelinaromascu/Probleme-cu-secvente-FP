using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    class Program
    { //Problema 2
      //Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 

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
            return v;
        }
        
        static void Main(string[] args)
        {
            int negative = 0, nule = 0, pozitive = 0; ;

            int[] v = citireSecventa();

            for(int i = 0;i < v.Length; i++)
            {
                if(v[i] < 0)
                {
                    negative++;
                    //negative = negative + 1;

                }else if (v[i] == 0)
                {
                    nule++;

                } else if (v[i] > 0)
                {
                    pozitive++;
                }
            }
            Console.WriteLine(); 
            Console.WriteLine("Numere negative: " + negative);
            Console.WriteLine("Numere nule: " + nule);
            Console.WriteLine("Numere pozitive: " + pozitive);
        }
    }
}
