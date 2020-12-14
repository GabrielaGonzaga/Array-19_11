using System;

namespace Desafio_9_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array e Vetor");

            // nomes[0] = "Gabriela";
            // nomes[1] = "Gabriela";
            // nomes[2] = "Gabriela";

            // Console.WriteLine("Nome:" +nomes[1]);

            string[] nomes = new string[5];
            int[] idades = new int [5];

            for (var contador = 0; contador < 5; contador++){
                Console.WriteLine("Digite o nome");
                nomes[contador] =  Console.ReadLine();
                Console.WriteLine("Digite a idade");
                idades[contador] = int.Parse(Console.ReadLine());
            }

            // Console.WriteLine("Nomes cadastrados:");
            // Console.WriteLine(nomes[0]);
            // Console.WriteLine(nomes[1]);
            // Console.WriteLine(nomes[2]);
            // Console.WriteLine(nomes[3]);
            // Console.WriteLine(nomes[4]);

            Console.WriteLine("Nomes cadastrados:");
            for(var contador = 0; contador < 5; contador++){
                Console.WriteLine("Nome:" +nomes[contador]);
                Console.WriteLine("Idade:" +idades[contador]);
            }
            
        }
    }
}
