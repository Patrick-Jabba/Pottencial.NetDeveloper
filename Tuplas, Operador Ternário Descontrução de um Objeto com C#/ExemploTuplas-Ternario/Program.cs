(int, string, string, decimal) tupla = (1, "Patrick", "Monteiro", 10.5M);
ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Leonardo", "Buta", 1.80M);

var outroExemploTuplaCreate = Tuple.Create(1, "Leo", "Buta", 1.80M);

Console.WriteLine($"Id: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");