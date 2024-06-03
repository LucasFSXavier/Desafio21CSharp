using Interfaces.SOLID.OCP.QuebrandoRegra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.SOLID.OCP.Solucao
{
    public interface IPessoa
    {
        int Id { get; set; }
        string Nome { get; set; }

        void Salvar();
    }
}
