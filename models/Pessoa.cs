using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.net.models
{
    public class Pessoa
    {
        // Adicione um construtor com valores padrão para Nome e Idade.
        public Pessoa(string nome = "", int idade = 0)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, Meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}