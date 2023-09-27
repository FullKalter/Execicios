Int32 qtddSucos;
decimal valorSuco;

Console.WriteLine("Digite a quantidade de Sucos: ");
qtddSucos = Convert.ToInt32(Console.ReadLine());

if(qtddSucos > 10)
{
    valorSuco = 4.50m;
}
else
{
    valorSuco = 5.50m;
}

Console.WriteLine("O Valor Total da sua Compra foi: R$ " + (qtddSucos * valorSuco));
