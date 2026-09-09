using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


class Program
{
    static int LerOpcaoValida(int min, int max)
    {
        int valor;
        while (!int.TryParse(Console.ReadLine(), out valor) || valor < min || valor > max)
        {
            Console.Write($"Entrada inválida! Digite apenas um número entre {min} e {max}: ");
        }
        return valor;
    }

    static void Main()
    {

        Pedido meuPedido = new Pedido();

        int opcoes = 0;
        int pedido = 0;
        int tipoRefri = 0;

        do
        {
            Console.WriteLine("\n Bem-vindo a Lanchonete Breninho Lanches, papai!!!");
            Console.WriteLine("\n A mais braba da Bahiaaa:\n");
            Console.WriteLine("1 - Continuar Comprando");
            Console.WriteLine("2 - Cancelar");
            Console.WriteLine("3 - Finalizar compra");
            Console.Write("Opção: ");
            opcoes = LerOpcaoValida(1, 3);

            switch (opcoes)
            {
                case 1:
                    Console.WriteLine("\nProdutos disponíveis:");
                    Console.WriteLine("1 - Hambúrguer (R$ 20)");
                    Console.WriteLine("2 - Pizza (R$ 35)");
                    Console.WriteLine("3 - Refrigerante");
                    Console.Write("Escolha seu item: ");
                    pedido = LerOpcaoValida(1, 3);

                    switch (pedido)
                    {
                        case 1:

                            Lanche burguer = new Lanche
                            {
                                Codigo = 1,
                                Descricao = "Hambúrguer",
                                PrecoBase = 20.0
                            };

                            Console.Write("Deseja adicionar Queijo Extra (+R$ 3,00)? (S/N): ");

                            string opcaoQueijo = Console.ReadLine()?.Trim().ToUpper();
                            if (opcaoQueijo == "S")
                            {
                                burguer.IngredientesExtras.Add("Queijo Extra");
                            }

                            meuPedido.Itens.Add(burguer);
                            Console.WriteLine("Hambúrguer adicionado ao carrinho!");
                            break;

                        case 2:
                            Lanche pizza = new Lanche
                            {
                                Codigo = 2,
                                Descricao = "Pizza",
                                PrecoBase = 35.0
                            };

                            meuPedido.Itens.Add(pizza);
                            Console.WriteLine("Pizza adicionada ao carrinho!");
                            break;

                        case 3:
                            Console.WriteLine("\nOpções de Refri:");
                            Console.WriteLine("1 - Dolly (R$ 2)");
                            Console.WriteLine("2 - Iti de Guaraná (R$ 1)");
                            Console.WriteLine("3 - Goob (R$ 3)");
                            Console.Write("Escolha a marca: ");
                            tipoRefri = LerOpcaoValida(1, 3);

                            Bebida refri = new Bebida();

                            switch (tipoRefri)
                            {
                                case 1:
                                    Console.WriteLine("Você escolheu o pior pqpkkk");
                                    refri.Codigo = 101;
                                    refri.Descricao = "Dolly";
                                    refri.PrecoBase = 2.0;
                                    break;
                                case 2:
                                    Console.WriteLine("Você escolheu o de durokkkk");
                                    refri.Codigo = 102;
                                    refri.Descricao = "Iti de Guaraná";
                                    refri.PrecoBase = 1.0;
                                    break;
                                case 3:
                                    Console.WriteLine("Você escolheu o melhorzinho");
                                    refri.Codigo = 103;
                                    refri.Descricao = "Goob";
                                    refri.PrecoBase = 3.0;
                                    break;
                                default:
                                    Console.WriteLine("Marca inválida!");
                                    refri = null;
                                    break;
                            }

                            string tamanho = "";
                            while (tamanho != "300ML" && tamanho != "500ML" && tamanho != "1L")
                            {
                                Console.Write("Escolha o tamanho (300ml, 500ml, 1L): ");
                                tamanho = Console.ReadLine()?.Trim().ToUpper();

                                if (tamanho != "300ML" && tamanho != "500ML" && tamanho != "1L")
                                {
                                    Console.WriteLine("Tamanho inválido! Digite exatamente 300ml, 500ml ou 1L.");
                                }
                            }

                            switch (tamanho)
                            {
                                case "300ML":
                                    refri.Tamanho = "300ml";
                                    break;
                                case "500ML":
                                    refri.Tamanho = "500ml";
                                    refri.PrecoBase *= 1.5;
                                    break;
                                case "1L":
                                    refri.Tamanho = "1L";
                                    refri.PrecoBase *= 2.0;
                                    break;
                            }

                            meuPedido.Itens.Add(refri);
                            Console.WriteLine($"{refri.Descricao} ({refri.Tamanho}) adicionado!");
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("Cancelando Compra!");
                    meuPedido.Itens.Clear();
                    break;

                case 3:
                    Console.WriteLine("\nRESUMO DO PEDIDO");
                    foreach (var item in meuPedido.Itens)
                    {
                        Console.WriteLine($"- {item.Descricao}: R$ {item.CalcularPreco()}");
                    }
                    Console.WriteLine($"\nTotal final: R$ {meuPedido.CalcularTotal()}");
                    break;
            }

        } while (opcoes != 2 && opcoes != 3);
    }
}