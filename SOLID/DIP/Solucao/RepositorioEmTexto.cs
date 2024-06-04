using System.Data.SqlClient;
using System;

namespace Interfaces.SOLID.DIP.Solucao
{
    public class RepositorioEmTexto : IRepositorio
    {
        public RepositorioEmTexto() { }

        public void Salvar(ref Cliente cliente)
        {
            Console.WriteLine("Implementando o método salvar em formato de arquivo de texto");
        }
    }
}