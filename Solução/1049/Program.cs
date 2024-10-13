using System;

class URI
{

    static void Main(string[] args)
    {

        var tipoPrincipal = Console.ReadLine().ToLower();
        var tipoSecundario = Console.ReadLine().ToLower();
        var tipoTerciario = Console.ReadLine().ToLower();
        definirAnimal(tipoPrincipal, tipoSecundario, tipoTerciario);

    }
    static void definirAnimal(string primario, string secundario, string terciario)
    {
        if (primario == "vertebrado")
        {
            if (secundario == "ave")
            {
                if (terciario == "carnivoro")
                {
                    Console.WriteLine("aguia");
                }
                else if (terciario == "onivoro")
                {
                    Console.WriteLine("pomba");
                }
            }
            else if (secundario == "mamifero")
            {
                if (terciario == "onivoro")
                {
                    Console.WriteLine("homem");
                }
                else if (terciario == "herbivoro")
                {
                    Console.WriteLine("vaca");
                }
            }
        }
        else if (primario == "invertebrado")
        {
            if (secundario == "inseto")
            {
                if (terciario == "hematofago")
                {
                    Console.WriteLine("pulga");
                }
                else if (terciario == "herbivoro")
                {
                    Console.WriteLine("lagarta");
                }
            }
            else if (secundario == "anelideo")
            {
                if (terciario == "hematofago")
                {
                    Console.WriteLine("sanguessuga");
                }
                else if (terciario == "onivoro")
                {
                    Console.WriteLine("minhoca");
                }
            }
        }
    }


}