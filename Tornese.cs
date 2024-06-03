using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Tornese : Tup
    {
        public Tornese() 
        {
            this.Marca = "Tornse";        
        }
        public override void Salvar()
        {
            base.Salvar();
            Console.WriteLine($"Novo comportamento para Salvar() da marca {Marca}");
        }

        public new void Buscar()
        {
            base.Buscar(); // Ação original
            Console.WriteLine("Ação para busca 2");
        }
    }
}
