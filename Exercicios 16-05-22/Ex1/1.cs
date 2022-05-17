// 1) Desenvolva um algoritmo que calcule a idade média dos alunos de uma classe da faculdade,sabendo que o aluno mais novo 
// tem 20 anos e o mais velho tem 50 anos, utilize a seguinte fórmula para calcular: MEDIA ALUNO = (IDADE MÍNIMA + IDADE MÁXIMA) / 2;


int idadeMedia(int min, int max)
{
    return (min + max) / 2;
}

int novo = 20, velho = 50;
idadeMedia(novo, velho);
Console.WriteLine("1) idade media eh: {0}", idadeMedia(novo, velho));