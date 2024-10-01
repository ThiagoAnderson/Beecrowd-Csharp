using System;

class URI
{

    static void Main(string[] args)
    {

        var distancia = int.Parse(Console.ReadLine());
        var combustivel = double.Parse(Console.ReadLine());
        var consumo = distancia / combustivel;
        Console.WriteLine($"{consumo:F3} km/l");

    }

}