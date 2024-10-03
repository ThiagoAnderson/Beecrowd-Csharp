using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[] Valores = Console.ReadLine().Split(' ');
        VerificarTrangulo(Valores);

    }
    static void VerificarTrangulo(string[] Valores)
    {

        var A = Convert.ToDouble(Valores[0], CultureInfo.InvariantCulture);
        var B = Convert.ToDouble(Valores[1], CultureInfo.InvariantCulture);
        var C = Convert.ToDouble(Valores[2], CultureInfo.InvariantCulture);

        if (A < B + C && B < A + C && C < B + C)
        {
            Console.WriteLine($"Perimetro = {(A + B + C):F1}");
        }
        else
        {
            var area = ((A + B) * C) / 2;
            Console.WriteLine($"Area = {area:F1}");
        }
    }
}

