﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.SOLID.DIP.Solucao
{
    public class Repositorio : IRepositorio
    {
        public Repositorio() { }

        public void Salvar(ref Cliente cliente)
        {
            Console.WriteLine("Salvando dados no banco de dados");
            using (var cn = new SqlConnection()) // Acoplamento forte de dependência do SqlConnection
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = "MinhaStringConnection";
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into clientes (...";

                cn.Open();
                cliente.ID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            Console.WriteLine("Salvando objetos no banco de dados");
        }
    }
}
