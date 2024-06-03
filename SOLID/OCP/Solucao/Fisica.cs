using Interfaces.SOLID.OCP.QuebrandoRegra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.SOLID.OCP.Solucao
{
    public class Fisica : IPessoa, IFisica, IFornecedor
    {
        public Fisica() { }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Credenciamento { get; set; }

        public void Salvar()
        {
            Console.WriteLine("Salvando Física que é fornecedora");
        }
    }
}