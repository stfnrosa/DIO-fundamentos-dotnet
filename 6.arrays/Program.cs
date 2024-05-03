int[] arrayInteiros = new int[4];
 
arrayInteiros[0] = 72;
arrayInteiros[1] = 64; 
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;  
// -> como foi determinado 3 como limite do array, caso este quarto seja executaso o programa ira quebrar;

// Percorrendo com FOR
for(int contador = 0;contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição Nº{contador+1}: {arrayInteiros[contador]}");   
}

// Percorrendo FOREACH 
foreach (int valor in arrayInteiros)
{
    Console.WriteLine(valor);
}

// Almentando o tamanho do array
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
Console.WriteLine(arrayInteiros.Length);
// Resize cria um novo array e tranfere todos os elenmentos do antigo para o novo, com capacidade nova, um array é craido com tamanho e acaba com o mesmo

//Copiando os elementos de um array para outro (Resize)
int[] arrayInteiros2 = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteiros2, arrayInteiros.Length); 
// array copiado, copia do array, quantos elementos deseja copiar

//Listas trabalham internamente com arrays, mas não é necessario se preocupar com tamanho, pois ela se ajusta conforme a utilização;

List<string> listaString = new List<string>();

listaString.Add("São Paulo");
listaString.Add("Bahia");
listaString.Add("Minas Gerais");

for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição Nº {contador+1}- {listaString[contador]}");
}

foreach (string item in listaString)
{
    Console.WriteLine($"{item}");  
}

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");  