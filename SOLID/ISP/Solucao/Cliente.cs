using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.SOLID.ISP.Solucao
{
    public class Cliente : IPagamento
    {
        public Cliente() { }
        public int Id { get; set; }

        public void Alterar()
        {
            Console.WriteLine("Implementação");
        }

        public void Excluir()
        {
            Console.WriteLine("Implementação");
        }

        public void Salvar()
        {
            Console.WriteLine("Implementação");
        }
        public void Pagar()
        {
            Console.WriteLine("Implementação");
        }
    }
}
