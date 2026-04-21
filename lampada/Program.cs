using System;

class Program
{
    static void Main()
    {
        var lampada = new LampadaInteligente("Philips", "LED");

        int opcao;

        do
        {
            Console.WriteLine("\n===== CONTROLE DA LÂMPADA =====");
            Console.WriteLine("1 - Ligar/Desligar");
            Console.WriteLine("2 - Ajustar brilho");
            Console.WriteLine("3 - Ver estado");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    lampada.Alternar();
                    Console.WriteLine("Estado alterado!");
                    break;

                case 2:
                    try
                    {
                        Console.Write("Digite o brilho (0 a 100): ");
                        int brilho = int.Parse(Console.ReadLine());

                        lampada.AjustarBrilho(brilho);
                        Console.WriteLine("Brilho ajustado!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro: " + e.Message);
                    }
                    break;

                case 3:
                    Console.WriteLine("\nEstado atual:");
                    Console.WriteLine(lampada);
                    break;

                case 0:
                    Console.WriteLine("Encerrando...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 0);
    }
}
