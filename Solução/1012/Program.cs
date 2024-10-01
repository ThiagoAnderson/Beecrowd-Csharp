using System;

class URI
{

    static void Main(string[] args)
    {

        string[] list1 = Console.ReadLine().Split(' ');
        var A = Convert.ToDouble(list1[0]);
        var B = Convert.ToDouble(list1[1]);
        var C = Convert.ToDouble(list1[2]);
        var areaTrianguloRetangulo = (A * C) / 2;
        var areaDoCirculo = 3.14159 * (C * C);
        var areaDoTrapezio = 0.5 * C * (A + B);
        var areaDoQuadrado = B * B;
        var areadoRetangulo = A * B;

        Console.WriteLine($"TRIANGULO: {areaTrianguloRetangulo:F3}");
        Console.WriteLine($"CIRCULO: {areaDoCirculo:F3}");
        Console.WriteLine($"TRAPEZIO: {areaDoTrapezio:F3}");
        Console.WriteLine($"QUADRADO: {areaDoQuadrado:F3}");
        Console.WriteLine($"RETANGULO: {areadoRetangulo:F3}");

    }

}