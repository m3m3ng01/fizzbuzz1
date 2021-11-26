using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan nilai yang diuji : ");
            int nilai = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nilai; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.Write("FizzBuzz" + " ");

                else if (i % 3 == 0)
                    Console.Write("Fizz" + " ");

                else if (i % 5 == 0)
                    Console.Write("Buzz" + " ");
                else
                    Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
