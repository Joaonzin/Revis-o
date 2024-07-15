using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    public class Gato : Animal
    {
        public Gato(string nome, int idade)
            : base(nome, idade)
        {
            RegistrarInformacoesAnimais();
        }

        public void Miar()
        {
            Console.WriteLine("Miau");
        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"Peso: {Peso}");
            Console.WriteLine($"Altura: {Altura}");
        }
    }
}

