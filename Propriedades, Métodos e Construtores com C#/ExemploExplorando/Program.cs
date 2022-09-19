using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Patrick", sobrenome: "Monteiro", idade: 34);

Pessoa p2 = new Pessoa(nome: "Leonardo", sobrenome: "Buta", idade: 37);

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

// p1.Apresentar();