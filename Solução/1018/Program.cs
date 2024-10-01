using System;

class URI
{

    static void Main(string[] args)
    {


        int[] notas = new int[7] { 100, 50, 20, 10, 5, 2, 1 };
        var valor = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(valor);
        foreach (int nota in notas)
        {
            Console.WriteLine($"{valor / nota} nota(s) de R$ {nota},00");
            valor = valor % nota;
        }



    }

}