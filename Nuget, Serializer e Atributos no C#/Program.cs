using Nuget__Serializer_e_Atributos_no_C_.Models;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda2> listaVenda = JsonConvert.DeserializeObject<List<Venda2>>(conteudoArquivo);

foreach (Venda2 venda in listaVenda)
{
  Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}

// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);



