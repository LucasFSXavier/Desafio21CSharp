using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.SOLID.LSP.Solucao
{
    public abstract class Fruta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public abstract string Cor(); 
    }
}
