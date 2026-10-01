using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static int LerOpcaoValida(int min, int max)
    {
        int valor;
        while (!int.TryParse(Console.ReadLine(), out valor) || valor < min || valor > max)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"[!] Entrada inválida! Digite apenas um número entre {min} e {max}: ");
            Console.ResetColor();
        }
        return valor;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Pedido meuPedido = new Pedido();

        int opcoes = 0;
        int pedido = 0;
        int tipoRefri = 0;

        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔═════════════════════════════════════════════════════╗");
            Console.WriteLine("║        LANCHONETE BRENINHO LANCHES, PAPAI!!!        ║");
            Console.WriteLine("║               A mais braba da Bahiaaa               ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════╝");
            Console.ResetColor();

 
            Console.WriteLine("\n [1] Fazer Pedido / Adicionar Item");
            Console.WriteLine(" [2] Cancelar Pedido");
            Console.WriteLine(" [3] Finalizar Compra e Pagar");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nOpção: ");
            Console.ResetColor();
            opcoes = LerOpcaoValida(1, 3);

            switch (opcoes)
            {
                case 1:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("--- PRODUTOS DISPONÍVEIS ---");
                    Console.ResetColor();
                    Console.WriteLine(" [1] Hambúrguer (R$ 20,00)");
                    Console.WriteLine(" [2] Pizza (R$ 35,00)");
                    Console.WriteLine(" [3] Refrigerante");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\nEscolha seu item: ");
                    Console.ResetColor();
                    pedido = LerOpcaoValida(1, 3);

                    switch (pedido)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(@"
          .---.
         /_____\
        (_______)
         (_____)
        (_______)
         \_____/");
                            Console.ResetColor();

                            Lanche burguer = new Lanche
                            {
                                Codigo = 1,
                                Descricao = "Hambúrguer",
                                PrecoBase = 20.0
                            };

                            Console.Write("\nDeseja adicionar Queijo Extra (+R$ 3,00)? (S/N): ");
                            string opcaoQueijo = Console.ReadLine()?.Trim().ToUpper();

                            while (opcaoQueijo != "S" && opcaoQueijo != "N")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("[!] Selecione um valor válido! (S/N): ");
                                Console.ResetColor();
                                opcaoQueijo = Console.ReadLine()?.Trim().ToUpper();
                            }

                            if (opcaoQueijo == "S")
                            {
                                burguer.IngredientesExtras.Add("Queijo Extra");
                            }

                            meuPedido.Itens.Add(burguer);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n[OK] Hambúrguer adicionado ao carrinho!");
                            Console.ResetColor();
                            break;

                        case 2:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine(@"
          / \
         /   \
        /  o  \
       / o   o \
      (_________)");
                            Console.ResetColor();

                            Lanche pizza = new Lanche
                            {
                                Codigo = 2,
                                Descricao = "Pizza",
                                PrecoBase = 35.0
                            };

                            meuPedido.Itens.Add(pizza);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n[OK] Pizza adicionada ao carrinho!");
                            Console.ResetColor();
                            break;

                        case 3:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(@"
          ||
         |===|
         |   |
         |___|");
                            Console.WriteLine("--- OPÇÕES DE REFRI ---");
                            Console.ResetColor();
                            Console.WriteLine(" [1] Dolly (R$ 2,00)");
                            Console.WriteLine(" [2] Iti de Guaraná (R$ 1,00)");
                            Console.WriteLine(" [3] Goob (R$ 3,00)");

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\nEscolha a marca: ");
                            Console.ResetColor();
                            tipoRefri = LerOpcaoValida(1, 3);

                            Bebida refri = new Bebida();

                            switch (tipoRefri)
                            {
                                case 1:
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("-> Você escolheu o pior pqpkkk");
                                    Console.ResetColor();
                                    refri.Codigo = 101;
                                    refri.Descricao = "Dolly";
                                    refri.PrecoBase = 2.0;
                                    break;
                                case 2:
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("-> Você escolheu o de durokkkk");
                                    Console.ResetColor();
                                    refri.Codigo = 102;
                                    refri.Descricao = "Iti de Guaraná";
                                    refri.PrecoBase = 1.0;
                                    break;
                                case 3:
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("-> Você escolheu o melhorzinho");
                                    Console.ResetColor();
                                    refri.Codigo = 103;
                                    refri.Descricao = "Goob";
                                    refri.PrecoBase = 3.0;
                                    break;
                            }

                            string tamanho = "";
                            while (tamanho != "300ML" && tamanho != "500ML" && tamanho != "1L")
                            {
                                Console.Write("\nEscolha o tamanho (300ml, 500ml, 1L): ");
                                tamanho = Console.ReadLine()?.Trim().ToUpper();

                                if (tamanho != "300ML" && tamanho != "500ML" && tamanho != "1L")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("[!] Tamanho inválido! Digite exatamente 300ml, 500ml ou 1L.");
                                    Console.ResetColor();
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
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\n[OK] {refri.Descricao} ({refri.Tamanho}) adicionado!");
                            Console.ResetColor();
                            break;
                    }

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n[X] Cancelando Compra!");
                    Console.ResetColor();
                    meuPedido.Itens.Clear();
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;

                case 3:
                    if (meuPedido.Itens.Count == 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n[!] Seu carrinho está vazio! Adicione algum item antes de finalizar.");
                        Console.ResetColor();
                        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                        Console.ReadKey();
                        break;
                    }

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("--- DADOS PARA FINALIZAR O PAGAMENTO ---");
                    Console.ResetColor();

                    Console.Write("\nDigite o nome do cliente: ");
                    string nome = Console.ReadLine()?.Trim();
                    while (string.IsNullOrWhiteSpace(nome))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[!] Nome não pode ser vazio. Digite novamente: ");
                        Console.ResetColor();
                        nome = Console.ReadLine()?.Trim();
                    }

                    Console.Write("Digite a forma de pagamento (Pix / Cartão / Dinheiro): ");
                    string pagamento = Console.ReadLine()?.Trim().ToLower();

                    while (string.IsNullOrWhiteSpace(pagamento) ||
                          (pagamento != "pix" && pagamento != "cartao" && pagamento != "cartão" && pagamento != "dinheiro"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[!] Opção inválida ou vazia. Digite novamente (Pix / Cartão / Dinheiro): ");
                        Console.ResetColor();
                        pagamento = Console.ReadLine()?.Trim().ToLower();
                    }

                    Console.WriteLine($"\nForma de pagamento selecionada com sucesso: {pagamento}");


                    IDadosPagamento resumo = meuPedido;
                    resumo.NomeCliente = nome;
                    resumo.FormaPagamento = pagamento;

              
                    resumo.ExibirResumoFinal();

                    Console.WriteLine("Pressione qualquer tecla para sair...");
                    Console.ReadKey();
                    return; 
            }

        } while (opcoes != 2);
    }
}