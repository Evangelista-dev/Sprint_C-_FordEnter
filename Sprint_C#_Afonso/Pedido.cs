using System;
using System.Collections.Generic;
using System.Text;


public class Pedido
{
    public List<ItemCardapio> Itens { get; set; } = new List<ItemCardapio>();

    public double CalcularTotal()
    {
        double total = 0;
        foreach (var item in Itens)
        {

            total += item.CalcularPreco();
        }
        return total;
    }
}
