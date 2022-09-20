using Exceções_e_Coleções_com_C_.Models;

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

Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);

foreach(int item in pilha)
{
  Console.WriteLine(item);
}
Console.WriteLine($"Removendo o elemento {pilha.Pop()} da pilha");

pilha.Push(20);
foreach(int item in pilha)
{
  Console.WriteLine(item);
}

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int item in fila)
{
  Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento {fila.Dequeue()} da fila");
fila.Enqueue(10);
foreach(int item in fila)
{
  Console.WriteLine(item);
}

new ExemploExcecao().Metodo1();


try
{
  string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

  foreach (string linha in linhas)
  {
    Console.WriteLine(linha);
  }
}
catch (FileNotFoundException ex)
{
  Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
  Console.WriteLine($"Pasta não encontrada. {ex.Message}");
}
catch (Exception ex)
{
  Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally
{
  Console.WriteLine("Chegou até aqui FINALMENTE!");
}