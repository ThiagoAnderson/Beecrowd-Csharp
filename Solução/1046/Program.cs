using System;

class URI
{

    static void Main(string[] args)
    {

        string[] Horarios = Console.ReadLine().Split(' ');
        CalcularTempo(Horarios);


    }
    static void CalcularTempo(string[] Horarios)
    {
        var hrInicio = Convert.ToInt32(Horarios[0]);
        var hrFim = Convert.ToInt32(Horarios[1]);
        var duracao = 0;

        if (hrInicio >= hrFim)
        {
            duracao = (24 + hrFim) - hrInicio;
            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
        }
        else
        {
            duracao = hrFim - hrInicio;
            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
        }

    }

}