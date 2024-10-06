using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[] Dados = Console.ReadLine().Split();
        VerificarTiposTriangulos(Dados);


    }
    static void VerificarTiposTriangulos(string[] Dados)
    {

        var N1 = float.Parse(Dados[2], CultureInfo.InvariantCulture);
        var N2 = float.Parse(Dados[1], CultureInfo.InvariantCulture);
        var N3 = float.Parse(Dados[0], CultureInfo.InvariantCulture);

        double A = 0, B = 0, C = 0;
        if (Math.Max(N1, N2) > N3)
        {
            A = Math.Max(N1, N2);
            if (A > Math.Max(N2, N3))
            {
                B = Math.Max(N2, N3);
                C = Math.Min(N2, N3);
            }
            else
            {
                B = Math.Max(N1, N3);
                C = Math.Min(N1, N3);
            }
        }
        else
        {
            A = N3;
            B = Math.Max(N1, N2);
            C = Math.Min(N1, N2);
        }


        if (A >= (B + C))
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {
            if (A * A == B * B + C * C)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (A * A > (B * B + C * C))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (A == B && B == C)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (A == B || A == C || B == C)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}