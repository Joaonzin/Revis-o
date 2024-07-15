using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    public class Cachorro : Animal
    {
        private string Raca { get; set; }

        public Cachorro(string nome, int idade, string raca)
            : base(nome, idade)
        {
            Raca = raca;
        }

        public void Latir()
        {
            Console.WriteLine("Latindo...");
        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"Raça: {Raca}");
        }
    }
}