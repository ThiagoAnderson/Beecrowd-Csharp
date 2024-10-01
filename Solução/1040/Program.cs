using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[] Notas = Console.ReadLine().Split(' ');
        CalcularMedia(Notas);

    }
    static void CalcularMedia(string[] Notas)
    {
        var n1 = float.Parse(Notas[0], CultureInfo.InvariantCulture);
        var n2 = float.Parse(Notas[1], CultureInfo.InvariantCulture);
        var n3 = float.Parse(Notas[2], CultureInfo.InvariantCulture);
        var n4 = float.Parse(Notas[3], CultureInfo.InvariantCulture);

        var media = Math.Floor((n1 * 2) + (n2 * 3) + (n3 * 4) + n4) * 0.10;
        Console.WriteLine($"Media: {media:F1}");
        if (media >= 7.0)
            Console.WriteLine("Aluno aprovado.");
        else if (media >= 5.0 && media <= 6.9)
        {
            Console.WriteLine("Aluno em exame.");
            var notaExame = float.Parse(Console.ReadLine());
            Console.WriteLine($"Nota do exame: {notaExame:F1}");
            var Novamedia = (media + notaExame) / 2;
            if (Novamedia >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine($"Media final: {Novamedia:F1}");
            }
            if (Novamedia < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
                Console.WriteLine($"Media final: {media:F1}");
            }
        }
        else
            Console.WriteLine("Aluno reprovado.");
    }
}