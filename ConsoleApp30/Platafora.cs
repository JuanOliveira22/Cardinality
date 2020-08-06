using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    class Platafora
    {
        public string Plataforma { get; set;}
        public List<Jogos> Joguinhos { get; set; }
       
        
        public Platafora()
        {

        }
       
        public Platafora(string plataforma)
        {
            Plataforma = plataforma;
        }

        public void Adicionar(string nome)
        {
            Joguinhos.Add(new Jogos(nome));
        }
    }
}
