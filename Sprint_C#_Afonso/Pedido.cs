using System;
using System.Collections.Generic;
using System.Text;


public class Pedido : IDadosPagamento
{

    public List<ItemCardapio> Itens { get; set; } = new List<ItemCardapio>();

  
    public string NomeCliente { get; set; }
    public string FormaPagamento { get; set; }
    public double ValorTotal { get; set; }

 
    public double CalcularTotal()
    {
        double total = 0;
        foreach (var item in Itens)
        {
            total += item.CalcularPreco();
        }
        ValorTotal = total; 
        return total;
    }

  
    public void ExibirResumoFinal()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("╔═════════════════════════════════════════════════════╗");
        Console.WriteLine("║                 RESUMO DO PEDIDO                    ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════╝");
        Console.ResetColor();

        Console.WriteLine($"\n Cliente:          {NomeCliente}");
        Console.WriteLine($" Forma Pagamento:  {FormaPagamento}\n");
        Console.WriteLine("--- ITENS SOLICITADOS ---");

        foreach (var item in Itens)
        {
            Console.WriteLine($" * {item.Descricao,-25} : R$ {item.CalcularPreco(),6:F2}");
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n─────────────────────────────────────────────────────");
        Console.WriteLine($" Total final: R$ {CalcularTotal():F2}");
        Console.WriteLine("─────────────────────────────────────────────────────\n");
        Console.ResetColor();
    }
}