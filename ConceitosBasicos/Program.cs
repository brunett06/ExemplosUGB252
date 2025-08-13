Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Informe seu salário: ");
decimal salario = decimal.Parse(Console.ReadLine());
Console.WriteLine("Seja bem-vinda(o), {0} o seu salário é {1}.",nome,salario);
if (salario <= 26963.20m)
{
    Console.WriteLine("Isento");
}
else if (salario >= 26963.21m && salario <= 33919.80m)
{
    Console.WriteLine($"O seu salário atual é {salario - salario * 0.075m}");
}
else if (salario >= 33919.81m && salario <= 45012.60m)
{
    Console.WriteLine($"O seu salário atual é {salario - salario * 0.15m}");
}
else if (salario >= 45012.61m && salario <= 55976.16m)
{
    Console.WriteLine($"O seu salário atual é {salario - salario * 0.225m}");
}
else
{
    Console.WriteLine($"O seu salário atual é {salario - salario * 0.275m}");
}
//informe o valor do IRPF a ser pago de acordo com o salário informado. Utilize a tabela real de desconto de IRPF