using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.SOLID.OCP.QuebrandoRegra
{
    public class Pessoa
    {
        public Pessoa() { }
        public int Id { get; set; }
        public string Nome{ get; set; }
        public TipoPessoa Tipo { get; set; }

        public void Salvar()
        {
            if (this.Tipo == TipoPessoa.Fisica)
            {
                Console.WriteLine("Salvando física");
            }
            else if (this.Tipo == TipoPessoa.Juridica)
            {
                Console.WriteLine("Salvando Jurídica");
            }
            else if (this.Tipo == TipoPessoa.Fornecedor)
            {
                Console.WriteLine("Salvando Fornecedor");
            }
        }
    }
}
