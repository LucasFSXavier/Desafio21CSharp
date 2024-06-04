using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.SOLID.DIP.QuebrandoRegra
{
    public class Cliente
    {
        public Cliente() { }
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }

        public bool Validado()
        {
            return string.IsNullOrEmpty(this.Nome) ? false : true;
        }
    }
}
