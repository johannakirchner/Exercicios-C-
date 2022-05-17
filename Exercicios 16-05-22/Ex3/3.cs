// 3) Desenvolva um algoritmo de comissão de vendas, um vendedor de carro vendeu 500 mil no mês de Maio, 
// sabendo que a comissão dele é de 5% ao mês, qual será o valor que este vendedor receberá de comissão, calcule e imprima;


void comissao(double vendas, double comis)
{
    Console.WriteLine("3) a comissao de {0} em vendas sera {1}", vendas, vendas * comis);
}

double vendas = 500000, comis = 0.05;
comissao(vendas, comis);
