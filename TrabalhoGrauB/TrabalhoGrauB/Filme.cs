﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrauB
{
    public class Filme : Midia
    {
        public string diretor;
        public string produtor;
        
        public override void ExibirInformacoes(int id)
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nome: " + titulo);
            Console.WriteLine("Diretor: " + diretor);
            Console.WriteLine("Produtor: " + produtor);
            Console.WriteLine("Ano: " + ano);
            Console.WriteLine("Genero: " + genero);
        }
        
    }
}
