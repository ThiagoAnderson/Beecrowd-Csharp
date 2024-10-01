using System;

class URI
{

    static void Main(string[] args)
    {

        var numFuncionario = int.Parse(Console.ReadLine());
        var numHorasTrabalhadas = int.Parse(Console.ReadLine());
        var valorPorHora = double.Parse(Console.ReadLine());
        var salario = numHorasTrabalhadas * valorPorHora;
        Console.WriteLine($"NUMBER = {numFuncionario}");
        Console.WriteLine($"SALARY = U$ {salario:F2}");

    }

}