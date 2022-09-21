using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_Poo.Models
{
    public class Aluno : Pessoa
    {
        public Aluno()
        {}
        public Aluno(double nota)
        {
            Nota = nota;
        }
        public double Nota { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Bem-vindo aluno {Nome}, sua nota é {Nota}");
        }
    }
}