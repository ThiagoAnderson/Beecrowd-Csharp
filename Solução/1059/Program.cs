﻿using System;

class URI
{

    static void Main(string[] args)
    {

        CemPrimeiros();

    }
    static void CemPrimeiros()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0) 
            {
                Console.WriteLine(i);
            }
        }
    }
}