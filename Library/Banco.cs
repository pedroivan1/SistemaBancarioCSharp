using System;
using System.Globalization;

namespace Banco;

public class ContaBancaria
{
    public string Titular;
    public decimal Saldo;

    public ContaBancaria(string titular, decimal saldo)
    {
        Titular = titular;
        Saldo = saldo;
    }
}
public class Banco
{

    // Recepcionar usuário - Método sem retorno
    public static void RecepcionarUsuario(ContaBancaria conta)
    {
        Console.WriteLine($"Boas vindas, {conta.Titular}.");
    }

    // Mostrar saldo - Método sem retorno
    public static void MostrarSaldo(ContaBancaria conta)
    {
        Console.WriteLine($"Seu saldo é: {conta.Saldo:C}");
    }

    // Verificador de saldo - Metodo com retorno
    public static bool VerificarSaldo(ContaBancaria conta, decimal amount)
    {
        return amount <= conta.Saldo;
    }
    // Transferir 1 - Metodo com sobrecarga
    public static void Transferir(ContaBancaria conta, string name)
    {
        Console.Write("Quanto você deseja transferir? ");
        string input = Console.ReadLine();
        if (decimal.TryParse(input, CultureInfo.InvariantCulture, out decimal quantia))
        {
            if (quantia < 0)
            {
                UI.Erro("Quantia inválida.");
            }
            else
            {
                if (VerificarSaldo(conta, quantia))
                {
                    conta.Saldo -= quantia;
                    Console.WriteLine($"Você transferiu {quantia:C} para {name}");
                }
                else
                {
                    UI.Erro("Saldo insuficiente.");
                }
            }
        }
        else
        {
            UI.Erro("Quantia inválida.");
        }
        
    }

    // Transferir 2 - Método com sobrecarga
    public static void Transferir(ContaBancaria conta)
    {
        Console.Write("Quanto você deseja transferir? ");
        string input = Console.ReadLine();
        if (decimal.TryParse(input, CultureInfo.InvariantCulture, out decimal quantia))
        {
            if (quantia < 0)
            {
                UI.Erro("Quantia inválida.");
            }
            else
            {
                if (VerificarSaldo(conta, quantia))
                {
                    conta.Saldo -= quantia;
                    Console.WriteLine($"Você transferiu {quantia:C}.");
                }
                else
                {
                    UI.Erro("Saldo insuficiente.");
                }
            }
        }
        else
        {
            UI.Erro("Quantia inválida.");
        }
    }

    public static void Depositar(ContaBancaria conta)
    {
        Console.Write("Quanto você deseja depositar? ");
        string input = Console.ReadLine();
        if (decimal.TryParse(input, CultureInfo.InvariantCulture, out decimal quantia))
        {
            if (quantia < 0)
            {
                UI.Erro("Quantia inválida.");
            }
            else
            {
                conta.Saldo += quantia;
                Console.WriteLine($"Você depositou {quantia:C}.");
            }
        }
        else
        {
            UI.Erro("Quantia inválida.");
        }
    }
    public static void Sacar(ContaBancaria conta)
    {
        Console.Write("Quanto você deseja sacar? ");
        string input = Console.ReadLine();
        if (decimal.TryParse(input, CultureInfo.InvariantCulture, out decimal quantia))
        {
            if (quantia < 0)
            {
                UI.Erro("Quantia inválida.");
            }
            else
            {
                if (VerificarSaldo(conta, quantia))
                {
                    conta.Saldo -= quantia;
                    Console.WriteLine($"Você sacou {quantia:C}.");
                }
                else
                {
                    UI.Erro("Saldo insuficiente.");
                }
            }
        }
        else
        {
            UI.Erro("Quantia inválida.");
        }
    }

}

