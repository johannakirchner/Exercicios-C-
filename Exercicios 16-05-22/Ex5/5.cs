// 5) Desenvolva um algoritmo para converter a temperatura em graus Fahrenheit para Celsius, a fórmula é C = (F -32) *5 / 9;


double FparaC(double F)
{
    return (F - 32) * 5 / 9;
}

double F = 99;
Console.WriteLine("5) {0} graus farenheit sao {1} graus celcius", F, FparaC(F));

