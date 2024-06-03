using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Tup : Carro
    {
        public Tup() 
        {
            this.Marca = "Tup";
        }

        public string Marca { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }

        private string logo = "imagem.jpg";

        public override void Salvar()
        {
            Console.WriteLine($"Ação para salvar os dados com o logo {logo} da marca {this.Marca}");
        }

        public override void Buscar()
        {
            Console.WriteLine("Ação para busca de dados");
        }

        public override List<Carro> BuscaPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}