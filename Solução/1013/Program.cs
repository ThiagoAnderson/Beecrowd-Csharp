using System;
class URI
{

    static void Main(string[] args)
    {

        string[] list1 = Console.ReadLine().Split(' ');
        var A = Convert.ToInt32(list1[0]);
        var B = Convert.ToInt32(list1[1]);
        var C = Convert.ToInt32(list1[2]);

        var maiorAB = (A + B + Math.Abs(A - B)) / 2;
        if (maiorAB > C)
        {
            Console.WriteLine($"{maiorAB} eh o maior");
        }
        else
        {
            Console.WriteLine($"{C} eh o maior");
        }
    }


}