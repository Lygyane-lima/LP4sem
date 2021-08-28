using System;

namespace Exercicio_Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.141459;
            double raio, area = 0.0;

            Console.Write("Digite o raio do circulo: ");
            raio = double.Parse(Console.ReadLine());

            area = PI * (raio * raio);

            Console.Write("Área do Círculo : " + area);
        }
    }
}
