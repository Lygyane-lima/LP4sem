using System;
using System.IO;
using System.Text;

namespace Exercicio_GerenciamentoDiretorio
{
    class Program
    {
        static void Main(string[] args)
        {

            string diretorio = @"C:\LP\LP4sem\Exercicio_Diretorio";


            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
                Console.WriteLine($"Diretório {diretorio } criado");

            }
            else
            {
                Console.WriteLine($"Diretório {diretorio } já existe");
            }
        }
    }
}

