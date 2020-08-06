using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    class Jogos
    {
        public string Jogo { get; set; }
        public List<Platafora> Plataform { get; set; }

        public Jogos(string jogo)
        {
            Jogo = jogo;
        }

        public Jogos()
        {
        }
    }
}
