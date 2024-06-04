using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.SOLID.DIP.Solucao
{
    public interface IRepositorio
    {
        void Salvar(ref Cliente cliente);
    }
}
