using System;

class URI
{

    static void Main(string[] args)
    {

        var notaA = float.Parse(Console.ReadLine());
        var notaB = float.Parse(Console.ReadLine());
        var notaC = float.Parse(Console.ReadLine());
        var somaDasNotas = (notaA * 2.0) + (notaB * 3.0) + notaC * 5.0;
        var mediaDasNotas = somaDasNotas / 10.00;
        Console.WriteLine($"MEDIA = {mediaDasNotas:F1}");

    }

}