using System;

namespace ExerciciosLP_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;

            try
            {
                Console.Write("Informe um valor: ");
                //  double.TryParse(Console.ReadLine(), out double valor);
                valor = double.Parse(Console.ReadLine());

                double numero = Convert.ToInt32(valor);

                // if (numero > 0)

                Console.WriteLine($"Conversão para inteiro : {numero} ");

            }

            catch (ArithmeticException ex)
            {
                Console.WriteLine("Erro de soma" + ex.Message);
            }

            catch (FormatException)
            {
                Console.WriteLine("Erro, não foi possível converter");
            }


        }

    }
}