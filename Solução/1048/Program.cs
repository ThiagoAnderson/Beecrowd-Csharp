using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        var salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        CalcularReajuste(salario);
    }
    static void CalcularReajuste(double salary)
    {
        double ajuste;

        if (salary > 0 && salary <= 400.00)
        {
            ajuste = salary * 0.15;
            salary = salary + ajuste;

            Console.WriteLine("Novo salario: " + salary.ToString("F2"));
            Console.WriteLine("Reajuste ganho: " + ajuste.ToString("F2"));
            Console.WriteLine("Em percentual: 15 %");
        }
        else if (salary <= 800.00)
        {
            ajuste = salary * 0.12;
            salary = salary + ajuste;

            Console.WriteLine("Novo salario: " + salary.ToString("F2"));
            Console.WriteLine("Reajuste ganho: " + ajuste.ToString("F2"));
            Console.WriteLine("Em percentual: 12 %");
        }
        else if (salary <= 1200.00)
        {
            ajuste = salary * 0.10;
            salary = salary + ajuste;

            Console.WriteLine("Novo salario: " + salary.ToString("F2"));
            Console.WriteLine("Reajuste ganho: " + ajuste.ToString("F2"));
            Console.WriteLine("Em percentual: 10 %");
        }
        else if (salary <= 2000.00)
        {
            ajuste = salary * 0.07;
            salary = salary + ajuste;

            Console.WriteLine("Novo salario: " + salary.ToString("F2"));
            Console.WriteLine("Reajuste ganho: " + ajuste.ToString("F2"));
            Console.WriteLine("Em percentual: 7 %");
        }
        else
        {
            ajuste = salary * 0.04;
            salary = salary + ajuste;

            Console.WriteLine("Novo salario: " + salary.ToString("F2"));
            Console.WriteLine("Reajuste ganho: " + ajuste.ToString("F2"));
            Console.WriteLine("Em percentual: 4 %");
        }
    }
}