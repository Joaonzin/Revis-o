using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão
{
    public class Funcionario : Pessoa
    {
        private int Matricula { get; set; }
        public string PlacaVeiculo { get; set; }

        public int MatriculaFuncionario()
        {
            int matricula = Matricula;
            return matricula;
        }

        public bool VerificarVeiculo(Automovel automovel)
        {
            if (PlacaVeiculo.Length == 7)
            {
                return true;
            }
            else            
            {
                return false;
            }
        }
    }
}