using Exemplo_Poo.Models;
using Exemplo_Poo.Interfaces;

Calculadora cal = new Calculadora();

cal.Somar(1, 2);

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3, 9));

// Computador c = new Computador();

// Console.WriteLine(c.ToString());


// Corrente corrente1 = new Corrente();

// corrente1.Creditar(1000M);

// corrente1.ExibirSaldo();

// Aluno a1 = new Aluno(7.7);

// a1.Nome = "João";
// a1.Idade = 22;

// a1.Apresentar();

// Professor p1 =  new Professor();
// p1.Nome = "Eduardo";
// p1.Idade= 76;
// p1.Salario = 1000M;
// p1.Apresentar();

// Pessoa p1 = new Pessoa();

// p1.Nome = "Patrick";
// p1.Idade = 34;

// p1.Apresentar();

// Pessoa p2 = new Pessoa("Mariane", 31);

// p2.Apresentar();


// ContaCorrente c1 = new ContaCorrente(123, 1000);

// c1.ExibirSaldo();
// c1.Sacar(500);
// c1.ExibirSaldo();
// c1.Depositar(550);
// c1.ExibirSaldo();
