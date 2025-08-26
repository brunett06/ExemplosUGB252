/*
try
{
    Console.WriteLine("Informe seu nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Informe seu salário: ");
    decimal salario = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Seja bem-vinda(o), {0} o seu salário é {1}.", nome, salario);

    decimal irpfDevido;
    if (salario <= 2259.20m)
        irpfDevido = 0;
    else if (salario <= 2826.65m)
        irpfDevido = salario * 0.075m - 169.21m;
    else if (salario <= 3751.05m)
        irpfDevido = salario * 0.15m - 381.44m;
    else if (salario <= 4664.68m)
        irpfDevido = salario * 0.225m - 662.77m;
    else
        irpfDevido = salario * 0.275m - 896m;

    Console.WriteLine($"Para o salário de {salario} o valor a ser pago de IRPF é {irpfDevido}, então o slário com desconto de IRPF será {salario - irpfDevido}.");
}
catch (FormatException)
{
    Console.WriteLine("O salário deve ser informado em formato númerico.");
}
catch (Exception e)
{
    Console.WriteLine("Ocorreu um erro. Contate o suporte técnico.");
    Console.WriteLine(e.StackTrace);
}
*/
//if (salario <= 2259.20m)
//{
//    Console.WriteLine("Isento");
//}
//else if (salario >= 2259.21m && salario <= 2826.65m)
//{
//    Console.WriteLine($"O seu salário atual é {salario - salario * 0.075m - 169.21m}");
//}
//else if (salario >= 2826.66m && salario <= 3751.05m)
//{
//    Console.WriteLine($"O seu salário atual é {salario - salario * 0.15m - 381.44m}");
//}
//else if (salario >= 3751.06m && salario <= 4664.68m - 662.77m)
//{
//    Console.WriteLine($"O seu salário atual é {salario - salario * 0.225m - 662.77m}");
//}
//else
//{
//    Console.WriteLine($"O seu salário atual é {salario - salario * 0.275m - 896m}");
//}
//informe o valor do IRPF a ser pago de acordo com o salário informado. Utilize a tabela real de desconto de IRPF


using ConceitosBasicos.uteis;


Console.WriteLine("Escolha o que você deseja fazer?");
Console.WriteLine("1- Soma Dois Números /n 2- Metros Metros /n 3-Calcula Aumento");
int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        SomaDoisNumeros somaDoisNumeros = new SomaDoisNumeros();
        Console.WriteLine("Informe o primeiro número: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo número: ");
        int n2 = int.Parse(Console.ReadLine());
        int resultado = somaDoisNumeros.Somar(n1, n2);
        Console.WriteLine(resultado);
        break;
    case 2:
        MetrosMilimetros metrosMilimetros = new MetrosMilimetros();
        int milimetros = MetrosMilimetros.Converter(50);
        Console.WriteLine(milimetros);
        break;
    case 3:
        CalculaAumento calculaAumento = new CalculaAumento();
        Console.WriteLine("Informe o salário: ");
        decimal salario = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Informe o percentual de aumento: ");
        float percentual = float.Parse(Console.ReadLine());
        decimal percentualAumento = calculaAumento.Calcular(salario, percentual);
        Console.WriteLine($"Para o salário {salario:c2}, o aumento de {percentual}% corresponde a {percentualAumento}");
        Console.WriteLine($"O novo salário é {salario + percentualAumento}");
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}


