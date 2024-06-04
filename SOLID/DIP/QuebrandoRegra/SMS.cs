using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.SOLID.DIP.QuebrandoRegra
{
    public class SMS
    {
        public bool Enviar(Cliente cliente)
        {
            Console.WriteLine("Enviando SMS para o Cliente");
            return true;
        }
    }
}
