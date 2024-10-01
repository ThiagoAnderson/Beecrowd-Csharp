string[] Pedido = Console.ReadLine().Split(' ');
var codigo = Convert.ToInt32(Pedido[0]);
var quantidade = Convert.ToInt32(Pedido[1]);
ValorTotal(codigo, quantidade);

static void ValorTotal( int codigo , int quantidade)
{
    switch (codigo)
    {
        case 1:
            Console.WriteLine($"Total:R$ {4.00 * quantidade:F2}");
                break;
        case 2:
            Console.WriteLine($"Total:R$ {4.50* quantidade:F2}");
            break;
        case 3:
            Console.WriteLine($"Total:R$ {5.00 * quantidade:F2}");
            break;
        case 4:
            Console.WriteLine($"Total:R$ {2.00 * quantidade:F2}");
            break;
        case 5:
            Console.WriteLine($"Total:R$ {1.50 * quantidade:F2}");
            break;
    }
}