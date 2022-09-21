using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_Poo.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }        
        public override void Apresentar()
        {
            Console.WriteLine($"Professor {Nome}, seu salário é " + Salario.ToString("C"));
        }
    }
}