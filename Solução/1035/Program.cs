﻿usingusing System;

class URI
{

    static void Main(string[] args)
    {

        string[] x = Console.ReadLine().Split(' ');
        var A = Convert.ToInt32(x[0]);
        var B = Convert.ToInt32(x[1]);
        var C = Convert.ToInt32(x[2]);
        var D = Convert.ToInt32(x[3]);

        if (B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0)
        {

            Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }
    }
}