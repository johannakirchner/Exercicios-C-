// 4)Desenvolva um algoritmo para converter a temperatura em graus Celsius para Fahrenheit, a fórmula é F = (9 * C + 160) / 5;


double CparaF(double C)
{
    return (9 * C + 160) / 5;
}

double C = 36.7;
Console.WriteLine("4) {0} graus celcius sao {1} graus farenheit", C, CparaF(C));
