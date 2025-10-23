//Arrays
string nome = "Eloysa";
Console.WriteLine($"Nome: {nome}");

//cria um array  tamanho 4 e preenche o vazio
string[] nomes = new string[4];

nomes[0] = "Maria";
nomes[1] = "Matheus";
nomes[2] = "Eloysa";
nomes[3] = "Felipe";

Console.WriteLine();

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);
}


// Console.WriteLine();
// Console.WriteLine(nomes[0]);
// Console.WriteLine(nomes[1]);
// Console.WriteLine(nomes[2]);
// Console.WriteLine(nomes[3]);
// Console.WriteLine(nomes[4]); //não existe