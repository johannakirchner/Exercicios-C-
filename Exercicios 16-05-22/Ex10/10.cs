// Desenvolver um algoritmo todos os algoritmos acima de forma dinâmica nos valores das variáveis, 
// ou seja, obtendo a informação digitada pelo teclado por um usuário e não declarando a variável 
// com um valor fixo

// 1)
void idadeMedia()
{
    Console.WriteLine("1) insira a idade maxima: ");
    int max = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("insira a idade minima: ");
    int min = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("idade media eh: {0}", (min + max) / 2);
}

idadeMedia();

// 2)
void cotacao()
{
    Console.WriteLine("2) insira a cotacao:");
    double cot = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("insira a quantidade de euros:");
    double euros = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("{0} euros sao {1} reais", euros, cot * euros);
}

cotacao();

// 3)
void comissao()
{
    Console.WriteLine("3) insira a comissao:");
    double comis = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("insira a quantidade de vendas:");
    double vendas = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("a comissao de {0} em vendas sera {1}", vendas, vendas * comis);
}

comissao();

// 4)
void CparaF()
{
    Console.WriteLine("4) insira a temperatura em C:");
    double C = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("{0} graus celcius sao {1} graus farenheit", C, (9 * C + 160) / 5);
}

CparaF();

// 5)
void FparaC()
{
    Console.WriteLine("5) insira a temperatura em F:");
    double F = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("{0} graus farenheit sao {1} graus celcius", F, (F - 32) * 5 / 9);
}

FparaC();

// 6)
void pesoIdeal()
{
    Console.WriteLine("6) insira a altura:");
    double h = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("o peso ideal eh {0}", (72.7 * h) - 58);
}

pesoIdeal();

// 7)
void media()
{
    Console.WriteLine("7) insira a primeira nota:");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("insira a segunda nota:");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("insira a terceira nota:");
    double c = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("insira a quarta nota:");
    double d = Convert.ToDouble(Console.ReadLine());

    double m = (a + b + c + d) / 4;
    Console.WriteLine("a media eh {0}", m);
    if (m >= 7)
    {
        Console.WriteLine("aluno aprovado.");
    }
    else
    {
        Console.WriteLine("aluno reprovado.");
    }
}

media();

// 8)
void subtracao()
{
    Console.WriteLine("8) o primeiro valor:");
    int a = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("insira o segundo valor:");
    int b = Convert.ToInt16(Console.ReadLine());

    int total = a - b;
    Console.WriteLine("total: {0}", total);
    if (total < 0)
    {
        Console.WriteLine("TOTAL NEGATIVO");
    }
    else
    {
        Console.WriteLine("TOTAL POSITIVO");
    }
}

subtracao();

// 9)
void resto()
{
    Console.WriteLine("9) o primeiro valor:");
    int a = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("insira o segundo valor:");
    int b = Convert.ToInt16(Console.ReadLine());
    if (b == 0)
    {
        Console.WriteLine("impossivel divisao por zero");
        return;
    }
    int resto = a % b;
    Console.WriteLine("resto: {0}", resto);

}

resto();

