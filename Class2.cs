﻿using System;
using System.Collections.Generic;
using System.Text;

public class Exercise32
{
    public static void Main()
    {

        int num, i, ctr = 0;

   

        Console.Write("Input  a number: ");
        num = Convert.ToInt32(Console.ReadLine());
        for (i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                ctr++;
                break;
            }
        }
        if (ctr == 0 && num != 1)
            Console.Write("{0} is a prime number.\n", num);
        else
            Console.Write("{0} is not a prime number\n", num);
    }
}
