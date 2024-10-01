using System;

class URI
{

    static void Main(string[] args)
    {

        var tempo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{tempo / 3600}:{(tempo % 3600) / 60}:{tempo % 60}");
    }

}