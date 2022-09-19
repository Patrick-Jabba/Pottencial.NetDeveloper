using ExemploExplorando.Models;
using System.Globalization;

string dataString = "2022-10-19 15:00";

bool sucesso = DateTime.TryParseExact(
  dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());

if(sucesso)
{
  Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else
{
  Console.WriteLine($"{dataString} não é uma data válida");
}



// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("C2"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##"));




// Pessoa p1 = new Pessoa(nome: "Patrick", sobrenome: "Monteiro", idade: 34);

// Pessoa p2 = new Pessoa(nome: "Leonardo", sobrenome: "Buta", idade: 37);

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();

// p1.Apresentar();