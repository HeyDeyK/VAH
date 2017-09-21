using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lode2
{
    enum Typy
    {
        Minuto, Lod
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Typy moznost = Typy.Prazdno;
            //Typy[] more = new Typy[3];


            int[,] PoleHrac1 = new int[10, 10];
            int[,] PoleHrac2 = new int[10, 10];

            PoleHrac1[1, 1] = 1;
            PoleHrac1[1, 2] = 2;
            if ((int)Typy.Minuto==PoleHrac1[1,3])
            {
                Console.WriteLine("Vedle!");
            }
            else
            {
                Console.WriteLine("Trefa!");
            }

            
            Console.WriteLine(PoleHrac1[0,0 ]);
            Console.ReadLine();
        }
    }
}
