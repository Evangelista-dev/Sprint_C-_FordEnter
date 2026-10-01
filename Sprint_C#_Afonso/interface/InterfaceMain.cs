using System;


public interface IDadosPagamento
{
    string NomeCliente { get; set; }
    string FormaPagamento { get; set; }
    double ValorTotal { get; set; }

    void ExibirResumoFinal();
}

public class InformacaoPedido : IDadosPagamento
{
    public string NomeCliente { get; set; }
    public string FormaPagamento { get; set; }
    public double ValorTotal { get; set; }

 
    public void ExibirResumoFinal()
    {
        Console.WriteLine("\n=================================");
        Console.WriteLine("       RESUMO FINAL DO PEDIDO    ");
        Console.WriteLine("=================================");
        Console.WriteLine($"Cliente:          {NomeCliente}");
        Console.WriteLine($"Forma Pagamento:  {FormaPagamento}");
        Console.WriteLine($"Valor Total:      R$ {ValorTotal:F2}");
        Console.WriteLine("=================================");
        Console.WriteLine("Obrigado pela preferência!");
    }
}