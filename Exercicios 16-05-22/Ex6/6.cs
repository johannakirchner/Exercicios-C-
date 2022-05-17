// 6) Desenvolver um algoritmo que leia a altura de um homem e calcule o seu peso ideal, utilize a 
// seguinte fórmula: PESO IDEAL = (72.7 * H) – 58, onde H = altura.

void pesoIdeal()
{
    Console.WriteLine("6) insira a altura:");
    double h = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("o peso ideal eh {0}", (72.7 * h) - 58);
}

pesoIdeal();
