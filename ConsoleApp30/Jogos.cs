﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    class Jogos
    {
        public string Jogo { get; set; }
        public List<Nintendo> PlataformaN { get; set; }
        public List<Microsoft> PlataformaM { get; set; }
        public List<Playstation> PlataformaP { get; set; }



        public Jogos(string jogo)
        {
            Jogo = jogo;
        }

        public Jogos()
        {
        }
    }
}
