using Interfaces.SOLID.OCP.QuebrandoRegra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.SOLID.OCP.Solucao
{
    public class Fornecedor : IPessoa, IFornecedor
    {
        public Fornecedor() { }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Credenciamento { get; set; }

        public void Salvar()
        {
            Console.WriteLine("Salvando Fornecedor");
        }
    }
}