int tabuada = 5;
int contador = 0;


// USANDO FOR
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{tabuada} X {i} = {tabuada * i}");   
}


// USANDO WHILE
while (contador <= 10)
{
    Console.WriteLine($"{tabuada} X {contador} = {tabuada * contador}"); 

    if (contador == 5)
    {
        break;
    }

    contador++;
}


// USANDO DO WHILE
int soma = 0;
int numero = 0;

do
{
    Console.WriteLine("Digite um número (Digite 0 para PARAR):");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;


}while(numero != 0);

Console.WriteLine($"Total da soma dos números digitados é: {soma}");