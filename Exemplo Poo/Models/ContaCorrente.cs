using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_Poo.Models
{
  public class ContaCorrente
  {
    public ContaCorrente(int numeroConta, decimal saldoInicial)
    {
      NumeroConta = numeroConta;
      saldo = saldoInicial;
    }
    public int NumeroConta { get; set; }
    private decimal saldo;
    public void Sacar(decimal valor)
    {
      if (saldo >= valor)
      {
        saldo -= valor;
        Console.WriteLine($"Sucesso: seu saldo atual é {saldo}");
      }
      else
      {
        Console.WriteLine("Valor desejado maior que o disponível");
      }
    }

    public void Depositar(decimal valor)
    {
      saldo += valor;
    }
    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual de : {saldo}");
    }
  }
}