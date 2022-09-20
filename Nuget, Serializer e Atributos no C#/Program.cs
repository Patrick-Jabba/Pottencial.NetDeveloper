using Nuget__Serializer_e_Atributos_no_C_.Models;
using Newtonsoft.Json;

int numero = 15;
bool par = false;

par = numero.verificaPar();

string mensagem = $"O número {numero} é " +  (par ? "par" : "ímpar");
Console.WriteLine(mensagem);


// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(30);

// Console.WriteLine(arrayInteiro[0]);


// dynamic variavelDinamica = 4;

// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica} ");

// variavelDinamica = "Texto";

// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica} ");



// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda2> listaVenda = JsonConvert.DeserializeObject<List<Venda2>>(conteudoArquivo);

// var listaAnonima = listaVenda.Select(item => new { item.Produto, item.Preco });

// foreach(var item in listaAnonima)
// {
//   Console.WriteLine($"Produt: {item.Produto}, Preço: {item.Preco}");
// }

// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);


// bool? desejaReceberEmail = true;

// if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//   Console.WriteLine($"O usuári optou por receber e-mail");
// }
// else 
// {
//   Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail");
// }


// var tipoAnonimo = new {Nome = "Patrick", Sobrenome = "Monteiro", Altura = 1.70};

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);
