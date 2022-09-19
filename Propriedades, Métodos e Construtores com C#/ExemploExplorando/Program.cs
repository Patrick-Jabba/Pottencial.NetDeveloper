using ExemploExplorando.Models;
using System.Globalization;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

// Console.WriteLine(estados["MG"]);

foreach(KeyValuePair<string, string> item in estados)
{
  Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("BA");
estados["SP"] = "São Paulo - valor alterado";

foreach(var item in estados)
{
  Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "SP";
Console.WriteLine($"Verificando o elemento: {chave}");

if(estados.ContainsKey(chave))
{
  Console.WriteLine($"Valor existente: {chave}");
}
else
{
  Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
}

// Stack<int> pilha = new Stack<int>();

// pilha.Push(2);
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);

// foreach(int item in pilha)
// {
//   Console.WriteLine(item);
// }
// Console.WriteLine($"Removendo o elemento {pilha.Pop()} da pilha");

// pilha.Push(20);
// foreach(int item in pilha)
// {
//   Console.WriteLine(item);
// }

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//   Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento {fila.Dequeue()} da fila");
// fila.Enqueue(10);
// foreach(int item in fila)
// {
//   Console.WriteLine(item);
// }

// new ExemploExcecao().Metodo1();


// try
// {
//   string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//   foreach (string linha in linhas)
//   {
//     Console.WriteLine(linha);
//   }
// }
// catch (FileNotFoundException ex)
// {
//   Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//   Console.WriteLine($"Pasta não encontrada. {ex.Message}");
// }
// catch (Exception ex)
// {
//   Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//   Console.WriteLine("Chegou até aqui FINALMENTE!");
// }





// string dataString = "2022-10-19 15:00";

// bool sucesso = DateTime.TryParseExact(
//   dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());

// if(sucesso)
// {
//   Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//   Console.WriteLine($"{dataString} não é uma data válida");
// }



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