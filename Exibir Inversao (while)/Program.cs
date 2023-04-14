using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exibir_Inversao__while_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomesEntrada = new string[5];
            int totalNomes = nomesEntrada.Length;

            int contador = 0;
            while (contador < nomesEntrada.Length) 
            {
                Console.WriteLine("Digite os nomes: ");
                nomesEntrada[contador] = Console.ReadLine();
                contador++;

                Console.Clear();
            }

            int contador2 = 0;
            while(contador2 < totalNomes)
            {
              Console.WriteLine("Nomes exibidos em ordem de cadastro: " + nomesEntrada[contador2]); 
                contador2++;                
            }

            int contador3 = totalNomes - 1;
            while(contador3 >= 0) 
            {
                Console.WriteLine("Nomes exibidos em ordem contraria: " + nomesEntrada[contador3]);
                contador3--;
            }
            Console.ReadKey();  
        }
    }
}
