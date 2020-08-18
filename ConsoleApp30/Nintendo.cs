using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    class Nintendo : Platafora
    {
   
        
            public int Armazenamento { get; set; }
        public List<Jogos> JogosN { get; set; }

        public Nintendo()
        {
        }

        public Nintendo( string nome, int armazenamento) : base(nome)
            {
            Nome = nome;

            Armazenamento = armazenamento;

            }

        

    }

}

