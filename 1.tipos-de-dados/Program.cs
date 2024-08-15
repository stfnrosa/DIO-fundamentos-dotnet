using tipos_de_dados.Models;
Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Estefani Rosa";
pessoa1.Idade = 23;
pessoa1.Apresentar();

// Representando a hora atual
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
// Somando horas
dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual);
// Alterando a estrutura 
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));