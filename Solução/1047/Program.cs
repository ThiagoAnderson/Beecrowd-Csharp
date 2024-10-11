using System;

class URI
{

    static void Main(string[] args)
    {

        string[] valores = Console.ReadLine().Split(' ');
        CalcularTempo(valores);

    }
    static void CalcularTempo(string[] valores)
    {
        int hi = Convert.ToInt32(valores[0]);
        int mi = Convert.ToInt32(valores[1]);
        int hf = Convert.ToInt32(valores[2]);
        int mf = Convert.ToInt32(valores[3]);

        int instanteInicial = hi * 60 + mi;
        int instanteFinall = hf * 60 + mf;
        int duracao;

        if (instanteInicial < instanteFinall)
        {
            duracao = instanteFinall - instanteInicial;
        }
        else
        {
            duracao = (24 * 60 - instanteInicial) + instanteFinall;
        }

        int duracaoHoras = duracao / 60;
        int duracaoMinutos = duracao % 60;

        Console.WriteLine($"O JOGO DUROU {duracaoHoras} HORA(S) E {duracaoMinutos} MINUTO(S)");

    }
}