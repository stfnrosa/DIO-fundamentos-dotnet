// See https://aka.ms/new-console-template for more information


//Atribuição 
int a = 10;
int b = 20;

int c = a + b;
Console.WriteLine(c);

//Combinando operadores
// c = c + 5;
c += 5;
Console.WriteLine(c);

// c = c - 5;
c -= 5;
Console.WriteLine(c);

//Convertendo os tipos - Cast ou Casting
int e = Convert.ToInt32("5");
int f = int.Parse("10");
Console.WriteLine(e);
Console.WriteLine(f);

//Convertendo STRING
int inteiro = 5;
string g = inteiro.ToString();

//Operadores condicionais -> IF
//Exemplo Verificação de Estoque:
int quantidadeEmEstoque = 10;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade em compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizaar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}
else if(possivelVenda)
{
	Console.WriteLine("Venda realizada com sucesso!");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque no momento!");
}

//Operadores condicionais -> SWITCH CASE
Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Não é uma Vogal");
        break;
}








