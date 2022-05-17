// 7) Desenvolver um algoritmo que leia quatro notas de um aluno, calcular a média e imprimir. 
// [OPCIONAL]: A pontuação deste exercício será maior para quem imprimir se o aluno for 
// APROVADO ou REPROVADO;
// [CRITÉRIO APROVAÇÃO]: Média > 7

void media(double a, double b, double c, double d)
{
    double m = (a + b + c + d) / 4;
    Console.WriteLine("7) a media eh {0}", m);
    if (m >= 7)
    {
        Console.WriteLine("aluno aprovado.");
    }
    else
    {
        Console.WriteLine("aluno reprovado.");
    }
}

double a = 7, b = 5.5, c = 6.7, d = 9;
media(a, b, c, d);
