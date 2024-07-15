using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    public class Animal
    {
        private string Nome { get; set; }
        private int Idade { get; set; }
        protected double Peso { get; set; }
        protected double Altura { get; set; }

        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void Comer()
        {
            Console.WriteLine("Comendo...");
        }

        public void Dormir()
        {
            Console.WriteLine("Dormindo...");
        }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
        }

        public void RegistrarInformacoesAnimais()
        {
            Console.WriteLine("Digite o peso do animal:");
            Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do animal:");
            Altura = double.Parse(Console.ReadLine());
        }
    }
}
