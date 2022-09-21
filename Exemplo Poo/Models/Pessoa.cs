using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_Poo.Models
{
    public class Pessoa
    {
        public Pessoa(){}
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos.");
        }
    }
}