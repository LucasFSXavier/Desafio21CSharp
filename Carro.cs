using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class Carro
    {
        public string Marca { get; set; }
        public string Roda {  get; set; }
        public string Porta { get; set; }
        public string Vidro { get; set; }

        public List<Carro> Todos ()
        { 
            return new List<Carro> ();
        }

        public abstract void Salvar();
        public abstract void Buscar();
        public abstract List<Carro> BuscaPorNome(string nome);

    }
}
