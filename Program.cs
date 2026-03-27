using System;
using System.Globalization;

namespace Banco;

class Program
{
    static void Main()
    {
        UI.LimparTela();
        bool mostrarMenu = true;
        Console.Write("Digite o seu nome: ");
        string nome = Console.ReadLine();
        ContaBancaria contaBancaria = new ContaBancaria(nome, 0);
        Banco.RecepcionarUsuario(contaBancaria);
        UI.Aguardar();

        do
        {
            UI.Menu();

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": // Sacar
                    Banco.Sacar(contaBancaria);
                    UI.Aguardar();
                    break;
                case "2": // Depositar
                    Banco.Depositar(contaBancaria);
                    UI.Aguardar();
                    break;
                case "3": // Transferir I 
                    Banco.Transferir(contaBancaria);
                    UI.Aguardar();
                    break;
                case "4": // Transferir II
                    Console.Write("Para quem você deseja transferir? ");
                    string destinatario = Console.ReadLine();
                    Banco.Transferir(contaBancaria, destinatario);
                    UI.Aguardar();
                    break;
                case "5": // Ver saldo
                    Banco.MostrarSaldo(contaBancaria);
                    UI.Aguardar();
                    break;
                case "6": // Sair
                    Console.WriteLine("Até a próxima.");
                    mostrarMenu = false;
                    break;
                default: // Opções inválidas
                    UI.Erro("Opção inválida.");
                    UI.Aguardar();
                    break;
            }
            
        }
        while (mostrarMenu);
    }
}