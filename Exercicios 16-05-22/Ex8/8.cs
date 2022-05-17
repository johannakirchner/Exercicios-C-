// 8) Desenvolver um algoritmo que leia dois valores, A e B, utilizar operador aritmético de subtração 
// e imprimir o total;

void subtracao(int a, int b)
{
    int total = a - b;
    Console.WriteLine("8) total: {0}", total);
    if (total < 0)
    {
        Console.WriteLine("TOTAL NEGATIVO");
    }
    else
    {
        Console.WriteLine("TOTAL POSITIVO");
    }
}

int a = 3, b = 5;
subtracao(a, b);