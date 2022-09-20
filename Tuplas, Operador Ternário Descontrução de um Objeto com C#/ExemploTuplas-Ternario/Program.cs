using ExemploTuplas_Ternario.Models;

int numero = 15;
bool par = false;

par = numero % 2 == 0;

Console.WriteLine($"O número {numero} é " + (par ? "par" : "ímpar"));

// if(numero % 2 == 0)
// {
//   Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//   Console.WriteLine($"O número {numero} é ímpar");
// }





// Pessoa p1 = new Pessoa("Leonardo", "Buta", 34);

// (string batatinha, string dromedario) = p1;

// Console.WriteLine($"{batatinha} {dromedario}");



// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if(sucesso)
// {
//   // Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
//   foreach(string linha in linhasArquivo)
//   {
//    Console.WriteLine(linha);
//   }
// }
// else
// {
//   Console.WriteLine("Não foi possível ler o arquivo");
// }





// (int, string, string, decimal) tupla = (1, "Patrick", "Monteiro", 10.5M);
// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Leonardo", "Buta", 1.80M);

// var outroExemploTuplaCreate = Tuple.Create(1, "Leo", "Buta", 1.80M);

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");

