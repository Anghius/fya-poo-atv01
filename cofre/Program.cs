using System;

class Program
{
    static void Main(string[] args)
    {
        // Criando o cofre
        CofreDigital cofre = new CofreDigital("Leonardo", "1234");

        Console.WriteLine("=== ESTADO INICIAL ===");
        Console.WriteLine(cofre);

        // Tentativas erradas
        Console.WriteLine("\n=== TESTANDO SENHA ERRADA ===");
        Console.WriteLine(cofre.Abrir("blabla"));
        Console.WriteLine(cofre.Abrir("papa"));
        Console.WriteLine(cofre.Abrir("fcknz"));

        // Cofre bloqueado
        Console.WriteLine("\n=== TENTANDO APÓS BLOQUEIO ===");
        Console.WriteLine(cofre.Abrir("1234"));

        // Resetando o cofre
        Console.WriteLine("\n=== RESETANDO COFRE ===");
        cofre.ResetarCofre();
        Console.WriteLine(cofre);

        // Abrindo corretamente
        Console.WriteLine("\n=== ABRINDO COM SENHA CORRETA ===");
        Console.WriteLine(cofre.Abrir("1234"));
        Console.WriteLine(cofre);

        // Alterando senha
        Console.WriteLine("\n=== ALTERANDO SENHA ===");
        Console.WriteLine(cofre.AlterarSenha("1234", "abcd"));

        // Fechando cofre
        Console.WriteLine("\n=== FECHANDO COFRE ===");
        cofre.Fechar();
        Console.WriteLine(cofre);

        // Testando nova senha
        Console.WriteLine("\n=== TESTANDO NOVA SENHA ===");
        Console.WriteLine(cofre.Abrir("abcd"));
        Console.WriteLine(cofre);
    }
}