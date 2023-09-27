decimal valorGazolina, valorEtanol, calculo;

Console.WriteLine("Digite o Valor da Gasolina R$: ");
valorGazolina = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o Valoe do Etanol R$: ");
valorEtanol = Convert.ToDecimal(Console.ReadLine());

calculo = valorEtanol / valorGazolina;

if(calculo >= 0.7m)
{
    Console.WriteLine("Compensa abastecer com GASOLINA");
}
else
{
    Console.WriteLine("Compensa abastecer com ETANOL");
}
