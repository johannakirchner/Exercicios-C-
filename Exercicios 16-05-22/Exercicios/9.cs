// 2)Desenvolva um algoritmo que leia a cotação do euro converta para o Real e imprima o resultado;

void cotacao(double euros)
{
    Console.WriteLine("2) insira a cotacao: ");
    double cot = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("{0} euros sao {1} reais\n\n", euros, cot * euros);
}

double euros = 750;

cotacao(euros);
