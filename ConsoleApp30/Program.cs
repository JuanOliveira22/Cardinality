using System;
using System.Collections.Generic;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Microsoft microsoft = new Microsoft();
            Nintendo nintendo = new Nintendo();
            Playstation playstation = new Playstation();
            Jogos jogos = new Jogos();

            jogos.PlataformaN = new List<Nintendo>();
            jogos.PlataformaM = new List<Microsoft>();
            jogos.PlataformaP = new List<Playstation>();
          

            Console.Write("Informe a plataforma desejada : (N/M/P) (Nintendo/Microsoft/Playstation): ");
            char n = char.Parse(Console.ReadLine());

            if (n == 'M' || n == 'm')
            {
                Console.WriteLine("Informe a quantidade de Registros : ");
                int m = int.Parse(Console.ReadLine());
                for (int i = 0; i < m; i++)
                {
                    int p = i + 1;
                    Console.Write($"Registro #{p} ");
                    Console.Write("Informe o nome : ");
                    string nome = Console.ReadLine();
                    Console.Write("Informe o espaço em disco :");
                    int armazenamento = int.Parse(Console.ReadLine());
                   

                    jogos.PlataformaM.Add(new Microsoft(nome,armazenamento));
                }
            }


            Console.WriteLine(jogos.PlataformaM[1].Nome);

        }
    }
}
