using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    class Microsoft : Platafora
    {

        public int Armazenamento { get; set; }
        public List<Jogos> JogosM { get; set; }

        public Microsoft()
        {
        }

        public Microsoft(string nome,int armazenamento) : base(nome)
        {
            Nome = nome;

            Armazenamento = armazenamento;


        }
        public override string TodosJogos()
        {
            return
                    Nome +
                   " Espaço em Disco : " +
                   Armazenamento;
        }


    }
}
