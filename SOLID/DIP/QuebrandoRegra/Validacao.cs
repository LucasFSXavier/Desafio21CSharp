using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.SOLID.DIP.QuebrandoRegra
{
    public class Validacao
    {
        public void Validar(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nome))
            {
                throw new Exception("O Nome é obrigatório");
            }

            if (string.IsNullOrEmpty(cliente.Telefone))
            {
                throw new Exception("O Telefone é obrigatório");
            }
        }
    }
}
