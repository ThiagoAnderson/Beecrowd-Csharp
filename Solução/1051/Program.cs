using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        calcularImposto(salario);

    }
    static void calcularImposto(double salario)
    {
        double impostoTotal = 0.0;
        double salarioAtual = 0.0;
        if (salario < 2000.00)
        {
            Console.WriteLine("Isento");
        }
        else if (salario > 2000.01 && salario <= 3000.00)
        {
            impostoTotal = (salario - 2000.00) * 0.08;
            Console.WriteLine($"R$ {impostoTotal:F2}");
        }
        else if (salario > 3000.01 && salario <= 4500.00)
        {
            var impostoFaixa1 = 80.00;
            impostoTotal = ((salario - 3000.00) * 0.18) + impostoFaixa1;
            Console.WriteLine($"R$ {impostoTotal:F2}");
        }
        else
        {
            var impostoFaixa3 = 80.00 + 270.00;
            impostoTotal = ((salario - 4500.00) * 0.28) + impostoFaixa3;
            Console.WriteLine($"R$ {impostoTotal:F2}");

        }
    }
}