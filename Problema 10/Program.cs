using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_10
{   //10.
    //Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
    class Program
    {
        //1 1 1 2 2 3 3 3 3 3 4 4 4 
        static void Main(string[] args)
        {
            int n, i, a, b, lc, lmax;
            Console.WriteLine("Introdu n: ");
                 n = int.Parse(Console.ReadLine());
                Console.Write("Introdu primul element-0: ");
                a = int.Parse(Console.ReadLine());
                lmax = 1;
                lc = 1;
                for (i = 1; i < n; i++)
                {
                    Console.Write("Introdu elementul-" + i +": ");
                    b = int.Parse(Console.ReadLine());
                    if (b == a)
                    {
                        lc++;
                        if (lc > lmax)
                            lmax = lc;
                    }
                    else                 
                     {
                        a = b;
                        lc = 1;
                    }
                }
                Console.WriteLine("Nr maxim de nr egale consecutive: " + lmax);
            }

        }
    }

