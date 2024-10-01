using System;

class URI
{

    static void Main(string[] args)
    {

        var nomeFuncionario = Console.ReadLine();
        var salario = double.Parse(Console.ReadLine());
        var vendas = double.Parse(Console.ReadLine());
        var porcentagemSobVendas = 0.15 * vendas;
        var valorTotal = salario + porcentagemSobVendas;
        Console.WriteLine($"TOTAL = R$ {valorTotal:F2}");

    }

}