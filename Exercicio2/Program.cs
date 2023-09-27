string nome;
decimal nota1, nota2, media;

Console.WriteLine("Digite Nome: ");
nome = Console.ReadLine();

Console.WriteLine("Digite a 1° Nota: ");
nota1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite A 2° Nota:");
nota2 = Convert.ToDecimal(Console.ReadLine());

media = (nota1 + nota2) / 2;

if(media >= 60)
{
    Console.WriteLine(nome + " você está APROVADO");
}
else
{
    Console.WriteLine(nome + " você está de RECUPERAÇÃO");
}
