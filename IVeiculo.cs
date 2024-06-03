using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IVeiculo
    {
        string Marca { get; set; }
        string Nome { get; set; }
        int Ano { get; set; }
        void Salvar();
    }
}
