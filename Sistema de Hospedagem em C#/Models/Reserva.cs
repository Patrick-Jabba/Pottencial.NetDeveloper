using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Hospedagem_em_C_.Models
{
  public class Reserva
  {
    public Reserva() { }
    public Reserva(int diasReservados)
    {
      DiasReservados = diasReservados;
    }
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
      //TODO: Verificar se a capacidade é maior ou iual ao número de hóspedes sendo recebido
      if (Suite.Capacidade >= hospedes.Count)
      {
        Hospedes = hospedes;
      }
      else
      {
        throw new ArgumentException("O número de hóspedes excede a capacidade da suíte");
      }
    }

    public void CadastrarSuite(Suite suite)
    {
      Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
      return Hospedes.Count;

    }

    public decimal CalcularValorDiaria()
    {

      double desconto = 1;
      decimal resultado = DiasReservados >= 10 ? (DiasReservados * Suite.ValorDiaria) - (Convert.ToDecimal(desconto) * Suite.ValorDiaria) : DiasReservados * Suite.ValorDiaria;
      return resultado;
    }

  }
}