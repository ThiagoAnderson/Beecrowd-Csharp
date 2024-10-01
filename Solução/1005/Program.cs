using System;

class URI
{

    static void Main(string[] args)
    {

        var notaA = float.Parse(Console.ReadLine());
        var notaB = float.Parse(Console.ReadLine());
        var somaDasNotas = ((notaA * 3.5) + (notaB * 7.5)) / 11.00;
        Console.WriteLine($"MEDIA = {somaDasNotas:F5}");

    }

}