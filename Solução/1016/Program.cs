using System;

class URI
{

    static void Main(string[] args)
    {

        var Km = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{tempoDeDistanciamento(Km)} minutos");


    }
    public static int tempoDeDistanciamento(int Km)
    {
        return Km * 2;
    }

}