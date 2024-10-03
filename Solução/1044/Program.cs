using System;

class URI
{

    static void Main(string[] args)
    {

        string[] Numeros = Console.ReadLine().Split(' ');
        CalcularMultiplos(Numeros);

    }
    static void CalcularMultiplos(string[] num)
    {
        var x = Convert.ToInt32(num[0]);
        var y = Convert.ToInt32(num[1]);


        if (Math.Max(x, y) % Math.Min(x, y) == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }

}