using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        ContarInteiros();
    }

    static void ContarInteiros()
    {
        List<float> numeros = new List<float>();

        for (int i = 0; i < 6; i++)
        {
            float num = float.Parse(Console.ReadLine());
            if (num > 0)
            {
                numeros.Add(num);
            }
        }
        Console.WriteLine($"{numeros.Count} valores positivos");
    }
}
