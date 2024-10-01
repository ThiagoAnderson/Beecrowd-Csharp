using System;

class URI
{

    static void Main(string[] args)
    {

        var raio = double.Parse(Console.ReadLine());
        var volume = 4 / 3.0 * 3.14159 * (raio * raio * raio);

        Console.WriteLine($"VOLUME = {volume:F3}");
    }

}