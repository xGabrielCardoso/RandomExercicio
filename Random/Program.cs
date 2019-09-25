using System;
using System.Collections.Generic;

namespace NumerosRandom
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int soma = 0;
            List<char> repetidos = new List<char>();

            Console.Write("Digite alguma palavra: ");
            string palavra = Console.ReadLine();
            Console.WriteLine("Atribuindo valor aleatoriamente..");

            char[] palavraSoletrada = palavra.ToCharArray();
            List<char> teste = new List<char>(palavraSoletrada);
            
            foreach (var letra in teste)
            {
                foreach (var duplicados in teste)
                {
                    if (letra == duplicados)
                    {
                        count++;
                    }
                    if (count > 1)
                    {
                        repetidos.Add(letra);
                        //teste.Remove(letra);
                    }
                        
                }

                foreach (var duplicado in repetidos)
                {
                    if (letra != duplicado)
                    {
                        int numeroInteiro = GerarNumeroAleatório();
                        soma += numeroInteiro;
                        count = 0;
                        Console.WriteLine(letra + " = " + numeroInteiro);
                    }
                    else
                    {
                        int numeroInteiro = GerarNumeroAleatório();
                        soma += numeroInteiro;
                        count = 0;
                        Console.WriteLine(letra + " = " + numeroInteiro);
                        //teste.Remove(duplicado);
                    }
                }


            }

            Console.WriteLine("Total = " + soma);
        }

        public static int GerarNumeroAleatório()
        {
            Random numAleatorio = new Random();
            return numAleatorio.Next(0, 101);
        }

    }
}
