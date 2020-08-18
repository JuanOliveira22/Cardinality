using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    class Playstation : Platafora
    {
        public int Armazenamento { get; set; }
        public List<Jogos> JogosP { get; set; }

        public Playstation()
        {
        }

        public Playstation(string nome, int armazenamento) : base( nome)
        {
            Nome = nome;

            Armazenamento = armazenamento;

        }
        
    }
  
    }





