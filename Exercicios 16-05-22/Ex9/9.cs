// 8) Desenvolver um algoritmo que leia dois valores, A e B, utilizar operador aritmético de divisão e
// modularização para, ou seja, imprimir apenas o resto da divisão.
// [OPCIONAL]: Tratar divisão por 0

void resto(int a, int b)
{
    if(b == 0)
    {
        Console.WriteLine("9) impossivel divisao por zero");
        return;
    }
    int resto = a % b;
    Console.WriteLine("9) resto: {0}", resto);

}

int a = 3, b = 0;
resto(a, b);