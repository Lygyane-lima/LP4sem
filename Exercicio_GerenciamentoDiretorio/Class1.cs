using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


    

namespace Exercicio_GerenciamentoDiretorio
{
    class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@"C:\LP\LP4sem\Exercicio_Diretorio\AulaFapen.txt"))
                {
                    writer.WriteLine("Estamos utilizando a classe StreamWriter para escrever esse código!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "  " + ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Finalizou a execução");
            }
        }
    }

