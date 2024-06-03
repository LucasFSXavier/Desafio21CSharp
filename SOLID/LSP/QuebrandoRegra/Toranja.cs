using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.SOLID.LSP.QuebrandoRegra
{
    public class Toranja
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual string Cor()
        {
            return "Vermelha";
        }
    }
}
