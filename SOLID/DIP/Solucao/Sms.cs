using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.SOLID.DIP.Solucao
{
    public class Sms
    {
        public bool Enviar(Cliente cliente, ISms iSms)
        {
            iSms.Enviar();
            Console.WriteLine("Enviando SMS para o Cliente");
            return true;
        }
    }
}
