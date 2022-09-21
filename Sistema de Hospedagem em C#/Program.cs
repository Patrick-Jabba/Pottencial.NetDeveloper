using System.Text;
using Sistema_de_Hospedagem_em_C_.Models;

Console.OutputEncoding = Encoding.UTF8;

//Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa (nome: "Patrick", sobrenome: "Monteiro");
Pessoa p2 = new Pessoa (nome: "Mariane", sobrenome: "Schenkel");

hospedes.Add(p1);
hospedes.Add(p2);

//Cria Suite
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 20);

// Cria uma nova reserva, passando a suite e os hospedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

//Exibe a quantidade de hóspedes e o valor da diária

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
