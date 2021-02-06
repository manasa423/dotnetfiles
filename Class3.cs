//factors of anumber

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Class3
    {
        static void Main(string[] args)
        {
            int num = 12;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{i} are the factors");
                }



            }
        }
    }
}
