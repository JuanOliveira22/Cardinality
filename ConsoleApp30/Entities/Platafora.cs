using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    class Platafora 
    {
        public string Nome { get; set;}
       
       
        
        public Platafora()
        {

        }
       
        public Platafora(string nome)
        {
            Nome = nome;
        }
        public virtual string TodosJogos()
        {
            return "Todos os Jogos : " +
                     Nome;
              

        }

    }
}
