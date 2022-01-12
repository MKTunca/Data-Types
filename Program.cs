using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            x = y;
            y = 5;
            Console.WriteLine(x);
            Console.WriteLine(y);

            string Name1 = "Mustafa";
            string Name2 = "Tuğrul";
            Name1 = Name2;
            string Name3 = "Turgay";
            Name2 = Name3;
            
            Console.WriteLine(Name1);
            Console.WriteLine(Name2);
            Console.WriteLine(Name3);

            int[] A = new int[] { 1, 2, 3 };
            int[] B = new int[] { 4, 5, 6 };
            A = B;
            B[1] = 8;
            Console.WriteLine(A[0]);
            Console.WriteLine(A[1]);
            Console.WriteLine(A[2]);
            Console.ReadLine();

        }
    }
}
