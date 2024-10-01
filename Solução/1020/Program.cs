using System;

class URI
{

    static void Main(string[] args)
    {

        var x = Convert.ToInt32(Console.ReadLine());

        var ano = x / 365;
        x = x % 365;

        var mes = x / 30;
        x = x % 30;

        var dias = x / 1;

        Console.WriteLine($"{ano} ano(s)");
        Console.WriteLine($"{mes} mes(es)");
        Console.WriteLine($"{dias} dia(s)");

    }

}