using System;

class URI
{

    static void Main(string[] args)
    {

        string[] ValoresIniciais = Console.ReadLine().Split(' ');
        OrdenarValores(ValoresIniciais);
    }
    static void OrdenarValores(string[] ValoresIniciais)
    {
        var v0 = Convert.ToInt32(ValoresIniciais[0]);
        var v1 = Convert.ToInt32(ValoresIniciais[1]);
        var v2 = Convert.ToInt32(ValoresIniciais[2]);

        int[] ValoresOriginais = { v0, v1, v2 };
        int[] Valores = { v0, v1, v2 };

        Array.Sort(Valores);

        foreach (int valor in Valores)
        {
            Console.WriteLine(valor);
        }

        Console.WriteLine("");

        foreach (int valor in ValoresOriginais)
        {
            Console.WriteLine(valor);
        }
    }
}