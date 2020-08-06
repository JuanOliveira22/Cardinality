using System;
using System.Collections.Generic;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Platafora platafora = new Platafora();
            Jogos jogos = new Jogos();

            jogos.Plataform = new List<Platafora>();
            platafora.Joguinhos = new List<Jogos>();

            Console.Write("Informe quantos registros : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Entre com a Plataforma : ");
                string plataforma = Console.ReadLine();
                Console.WriteLine("Entre com o jogo : ");
                string jogo = Console.ReadLine();
                

                jogos.Plataform.Add(new Platafora(plataforma));
                platafora.Joguinhos.Add(new Jogos(jogo));

               


            }
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(platafora.Joguinhos[j].Jogo + " é da plataforma : " + jogos.Plataform[j].Plataforma);
        
            }
           

        }
    }
}
