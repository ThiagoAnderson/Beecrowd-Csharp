using System;

class URI
{

    static void Main(string[] args)
    {

        var tempoGasto = int.Parse(Console.ReadLine());
        var velocidadeMediaCorrida = int.Parse(Console.ReadLine());
        var litrosGastos = quantidadeEmLitros(tempoGasto, velocidadeMediaCorrida);
        Console.WriteLine($"{litrosGastos:F3}");

    }
    public static double quantidadeEmLitros(int tempo, int velocidadeMedia)
    {
        var distanciaPercorrida = Convert.ToDouble(velocidadeMedia * tempo);

        return distanciaPercorrida / 12;
    }

}