using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.SOLID.ISP.QuebrandoRegra
{
    public interface IGenerica
    {
        int Id { get; set; }
        void Salvar();
        void Excluir();
        void Alterar();
        void Pagar(); // Responsabilidade utilizada somente em duas classes

    }
}
