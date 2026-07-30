//Declaração de variáveis
using System.Numerics;

double vhora, qhora, salariobruto, descontoIr, salarioliquido, inss, ir, fgts, totaldesconto;


try
{
    //Entrada de dados
    Console.Write("Digite o valor da hora: ");
    vhora = double.Parse(Console.ReadLine());
    Console.Write("Digite a quantidade de horas trabalhada: ");
    qhora = double.Parse(Console.ReadLine());

    // Processamento de dados
    salariobruto = vhora * qhora;
    inss = salariobruto - (10 / 100);
    fgts = salariobruto + (11 / 100);



    if ((salariobruto < 900) || (salariobruto == 900))
    {
        ir = 0;
        descontoIr = salariobruto * (ir/100);

    }
else if((salariobruto < 1500) || (salariobruto == 1500))
        {
        ir = 5;
        descontoIr = salariobruto * (ir/100);

    }
else if((salariobruto < 2500) || (salariobruto == 2500))
    {
        ir = 10;
        descontoIr = salariobruto * (ir / 100);

    }
else
    {
        ir = 20;
        descontoIr = salariobruto * (ir / 100);
    }

    totaldesconto = descontoIr + inss;

    //Saída de dados
    Console.WriteLine($"Salário Bruto: R$ {salariobruto:f2}");
    Console.WriteLine($"Desconto do IR: R$ {descontoIr:f2}");
    Console.WriteLine($"Desconto do INSS: R$ {inss:f2}");
    Console.WriteLine($"Valor do FGTS: R$ {fgts:f2}");
    Console.WriteLine($"Total de descontos: R$ {totaldesconto:f2}");
    Console.WriteLine($"Salário Líquido: R$ {ValorLiquido():f2}");
}
 catch
{
    Console.WriteLine("Valor inválido");
}



double ValorLiquido()
{
    salarioliquido = (salariobruto - descontoIr)- inss;
    return salarioliquido;
}

