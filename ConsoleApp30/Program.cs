using System;
using System.Collections.Generic;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {

            Jogos jogos = new Jogos();


            jogos.PlataformaN = new List<Nintendo>();
            jogos.PlataformaM = new List<Microsoft>();
            jogos.PlataformaP = new List<Playstation>();


            Console.WriteLine("Deseja adicionar algum registro ? (S/N)");
            char condicao = char.Parse(Console.ReadLine());
            while (condicao == 'S' || condicao == 's')
            {
                Console.Write("Informe a plataforma desejada :(N/M/P)(Nintendo/Microsoft/Playstation): ");
                char n = char.Parse(Console.ReadLine());
                if (n == 'p' || n == 'P')
                {
                    Console.WriteLine("Informe a quantidade de Registros : ");
                    int qnt = int.Parse(Console.ReadLine());
                    for (int i = 0; i < qnt; i++)
                    {
                        int p = i + 1;
                        Console.Write($"Registro #{p} :");
                        Console.WriteLine(" ");
                        Console.Write("Informe o nome : ");
                        string nome = Console.ReadLine();
                        Console.Write("Informe o espaço em disco :");
                        int armazenamento = int.Parse(Console.ReadLine());


                        jogos.PlataformaP.Add(new Playstation(nome, armazenamento));
                    }
                }


                if (n == 'M' || n == 'm')
                {
                    Console.WriteLine("Informe a quantidade de Registros : ");
                    int qnt = int.Parse(Console.ReadLine());
                    for (int i = 0; i < qnt; i++)
                    {
                        int p = i + 1;
                        Console.Write($"Registro #{p} :");
                        Console.WriteLine(" ");
                        Console.Write("Informe o nome : ");
                        string nome = Console.ReadLine();
                        Console.Write("Informe o espaço em disco :");
                        int armazenamento = int.Parse(Console.ReadLine());


                        jogos.PlataformaM.Add(new Microsoft(nome, armazenamento));
                    }
                }
                if (n == 'n' || n == 'N')
                {
                    Console.WriteLine("Informe a quantidade de Registros : ");
                    int qnt = int.Parse(Console.ReadLine());
                    for (int i = 0; i < qnt; i++)
                    {
                        int p = i + 1;
                        Console.Write($"Registro #{p} :");
                        Console.WriteLine(" ");
                        Console.Write("Informe o nome : ");
                        string nome = Console.ReadLine();
                        Console.Write("Informe o espaço em disco :");
                        int armazenamento = int.Parse(Console.ReadLine());


                        jogos.PlataformaN.Add(new Nintendo(nome, armazenamento));
                    }

                }
                Console.WriteLine("Deseja adicionar mais registros ? (S/N)");
                condicao = char.Parse(Console.ReadLine());

            }



            Console.WriteLine("Deseja ver todos os jogos de uma plataforma : (S/N) ");
            char m = char.Parse(Console.ReadLine());
            if (m == 'S' || m == 's')
            {
                Console.WriteLine("Selecione a plataforma que deseja ver os registros : (N/M/P)");
                char register = char.Parse(Console.ReadLine());
                if (register == 'M' || register == 'm')
                {
                    foreach (Microsoft prod in jogos.PlataformaM)
                    {
                        Console.WriteLine("Todos os jogos da Plataforma Microsoft : ");
                        Console.WriteLine(prod.TodosJogos());
                    }

                }
                if (register == 'N' || register == 'n')
                {
                    foreach (Nintendo prod in jogos.PlataformaN)
                    {
                        Console.WriteLine("Todos os jogos da Plataforma Microsoft : ");
                        Console.WriteLine(prod.TodosJogos());
                    }
                }
                if (register == 'P' || register == 'p')
                {
                    foreach (Playstation prod in jogos.PlataformaP)
                    {
                        Console.WriteLine("Todos os jogos da Plataforma Microsoft : ");
                        Console.WriteLine(prod.TodosJogos());
                    }
                }
            }
            else
            {
                jogos.Calcular();
                Console.WriteLine($" {jogos.ToString()}");
            }

            Console.WriteLine("Deseja remover algum registro ? (S/N)");
            char remocao = char.Parse(Console.ReadLine());
            if (remocao == 'S' || remocao == 's')
            {
                Console.WriteLine("Deseja remover o registro de qual plataforma ?(N/M/P) ");
                char escolhas = char.Parse(Console.ReadLine());
                if (escolhas == 'M' || escolhas == 'm')
                {
                    foreach (Microsoft prod in jogos.PlataformaM)
                    {
                        Console.WriteLine("Todos os jogos da Plataforma Microsoft : ");
                        Console.WriteLine(prod.TodosJogos());
                    }
                    Console.WriteLine("Selecione um dos registros acima : ");
                    int nintendinho = int.Parse(Console.ReadLine());
                    jogos.PlataformaM.Remove(jogos.PlataformaM[nintendinho]);
                    Console.WriteLine("JOGO REMOVIDO COM SUCESSO !!");
                    foreach (Microsoft prod in jogos.PlataformaM)
                    {
                        Console.WriteLine("Todos os jogos da Plataforma Microsoft : ");
                        Console.WriteLine(prod.TodosJogos());
                    }
                }
                if (escolhas == 'P' || escolhas == 'p')
                {
                    foreach (Playstation prod in jogos.PlataformaP)
                    {
                        Console.WriteLine("Todos os jogos da Plataforma playstation : ");
                        Console.WriteLine(prod.TodosJogos());
                    }
                    Console.WriteLine("Selecione um dos registros acima : ");
                    int nintendinho = int.Parse(Console.ReadLine());
                    jogos.PlataformaN.Remove(jogos.PlataformaN[nintendinho]);
                    Console.WriteLine("JOGO REMOVIDO COM SUCESSO !!");
                    foreach (Playstation prod in jogos.PlataformaP)
                    {
                        Console.WriteLine("Todos os jogos da Plataforma Playstation : ");
                        Console.WriteLine(prod.TodosJogos());
                    }
                }


                if (escolhas == 'n' || escolhas == 'N')
                {
                    foreach (Nintendo prod in jogos.PlataformaN)
                    {
                        Console.WriteLine("Todos os jogos da Plataforma Nintendo : ");
                        Console.WriteLine(prod.TodosJogos());
                    }
                    Console.WriteLine("Selecione um dos registros acima : ");
                    int nintendinho = int.Parse(Console.ReadLine());
                    jogos.PlataformaN.Remove(jogos.PlataformaN[nintendinho]);
                    Console.WriteLine("JOGO REMOVIDO COM SUCESSO !!");
                    foreach (Nintendo prod in jogos.PlataformaN)
                    {
                        Console.WriteLine("Todos os jogos da Plataforma Nintendo : ");
                        Console.WriteLine(prod.TodosJogos());
                    }

                }
                else
                {
                    Console.WriteLine("Obrigado por usar o programa !!");
                }


            }





        }
    }
}