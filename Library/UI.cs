using System;

namespace Banco;

public static class UI
{
    public static void Separador()
    {
        Console.WriteLine("======================");
    }

    public static void LimparTela()
    {
        Console.Clear();
    }

    public static void PularLinha()
    {
        Console.WriteLine();
    }
    public static void Menu()
    {   
        LimparTela();
        Separador();
        Console.WriteLine("        [MENU]        ");
        Separador();

        Console.WriteLine("[1] - Sacar");
        Console.WriteLine("[2] - Depositar");
        Console.WriteLine("[3] - Transferir");
        Console.WriteLine("[4] - Transferir para alguém");
        Console.WriteLine("[5] - Ver saldo");
        Console.WriteLine("[6] - Sair");
        PularLinha();

        Console.Write("Escolha uma opção: ");
    }

    public static void Aguardar()
    {
        System.Threading.Thread.Sleep(1250);
    }

    public static void Erro(string text)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(text);
        Console.ResetColor();
        Aguardar();
    }
}