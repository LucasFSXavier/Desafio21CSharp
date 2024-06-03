using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.SOLID.SRD.QuebrandoRegra
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }

        public void Salvar()
        {
            if (!this.Validacao()) throw new Exception("Erro na validação de dados");

            Console.WriteLine("Salvando dados no banco de dados");

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = "MinhaStringConnection";
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into clientes (...";
                cn.Open();
                this.ID = Convert.ToInt32(cmd.ExecuteScalar());
                Console.WriteLine("Salvando objetos no banco de dados");
            }

            this.EnviarSMS();
        }

        public void Excluir()
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn. ConnectionString = "MinhaStringConnection";
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                
                cn.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("Excluindo objetos no banco de dados");
            }
        }
        public bool EnviarSMS()
        {
            Console.WriteLine("Enviando SMS para o Cliente");
            return true;
        }

        public bool Validacao()
        {
            Console.WriteLine("Validando classe");
            return true;
        }

        public static List<Cliente> Buscar()
        {
            Console.WriteLine("Buscando lista de clientes");
            return new List<Cliente>();
        }
    }
}
