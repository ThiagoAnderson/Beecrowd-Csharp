using System;
using System.Globalization;


class URI
{

    static void Main(string[] args)
    {

        string[] Coordenadas = Console.ReadLine().Split(' ');
        CalcularCoordenadas(Coordenadas);

    }
    static void CalcularCoordenadas(string[] Coordenadas)
    {
        var x = float.Parse(Coordenadas[0], CultureInfo.InvariantCulture);
        var y = float.Parse(Coordenadas[1], CultureInfo.InvariantCulture);

        if (x == 0 && y == 0)
            Console.WriteLine("Origem");
        else if (x > 0 && y > 0)
            Console.WriteLine("Q1");
        else if (x < 0 && y > 0)
            Console.WriteLine("Q2");
        else if (x < 0 && y < 0)
            Console.WriteLine("Q3");
        else if (x > 0 && y < 0)
            Console.WriteLine("Q4");
        else if (x == 0 && y > 0 || y < 0)
            Console.WriteLine("Eixo Y");
        else if (y == 0 && x > 0 || x < 0)
            Console.WriteLine("Eixo X");
    }

}