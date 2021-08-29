using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_GerenciamentoDiretorio
{
    class Class2
    {

        static void LerTXT()
        {
            string linha;

            using (StreamReader reader = new StreamReader(@"C:\LP\LP4sem\Exercicio_Diretorio\AulaFapen.txt"))
            {
                {
                    linha = reader.ReadLine();
                }
                Console.WriteLine(linha);
            }
        }
}
