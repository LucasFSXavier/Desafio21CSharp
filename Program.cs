using Interfaces.SOLID.LSP.QuebrandoRegra;
using Interfaces.SOLID.OCP.Solucao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // SOLID - SRD
            var cliente = new Interfaces.SOLID.SRD.QuebrandoRegra.Cliente();
            cliente.Nome = "Lucas";
            cliente.Telefone = "12342365367";
            cliente.Salvar();

            var clienteSRP = new Interfaces.SOLID.SRD.Solucao.Cliente();
            cliente.Nome = "Lucas";
            cliente.Telefone = "12342365367";
            try
            {
                new Interfaces.SOLID.SRD.Solucao.Validacao().Validar(clienteSRP);
                new Interfaces.SOLID.SRD.Solucao.Repositorio().Salvar(ref clienteSRP);
                new Interfaces.SOLID.SRD.Solucao.SMS().Enviar(clienteSRP);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao validar a mensagem {ex.Message}");
            }

            // SOLID - OCR
            IPessoa pessoaFisica = new Fisica();
            IPessoa pessoaJuridica = new Juridica();
            
            pessoaFisica.Id = 1;
            pessoaFisica.Nome = "Nome";
            pessoaFisica.Salvar();

            pessoaJuridica.Id = 1;
            pessoaJuridica.Nome = "Nome";
            pessoaJuridica.Salvar();

            // SOLID - LSP
            // Errado
            Interfaces.SOLID.LSP.QuebrandoRegra.Toranja toranja = new Interfaces.SOLID.LSP.QuebrandoRegra.Laranja();
            Console.WriteLine(toranja.Cor());

            // Correto
            Interfaces.SOLID.LSP.Solucao.Fruta toranja2 = new Interfaces.SOLID.LSP.Solucao.Toranja();
            Console.WriteLine(toranja2.Cor());



            //Console.WriteLine("=================== TUP ==================");
            //var veiculo = new Tup();
            //veiculo.Ano = 2020;
            //veiculo.Nome = "004DV";
            //veiculo.Salvar();

            //Console.WriteLine("=================== Tornse ==================");
            //var veiculo2 = new Tornese();
            //veiculo2.Ano = 2020;
            //veiculo2.Nome = "005DV";
            //veiculo2.Salvar();

            //var joao = new Joao();
            //joao.Endereco = "Endereço";

            //Console.WriteLine("Digite");

            Console.ReadKey();
        }
    }
}
