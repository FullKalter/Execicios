string prioridade;

Console.WriteLine("Você precisa de atendimento prioritario? ");
prioridade = Console.ReadLine();

if(prioridade == "sim")
{
    Console.WriteLine("Vá para os Caixas 1, 2 e 3");
}
else
{
    Console.WriteLine("Vá para qualquer caixa, " +
        "exceto os caixas 1, 2 e 3 que são proritarios");
}
