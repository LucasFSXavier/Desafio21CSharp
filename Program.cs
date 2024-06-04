using Interfaces.SOLID.ISP.QuebrandoRegra;
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
            clienteSRP.Nome = "Lucas";
            clienteSRP.Telefone = "12342365367";
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

            // SOLID - ISP
            //Errado
            Interfaces.SOLID.ISP.QuebrandoRegra.IGenerica clienteISP = new Interfaces.SOLID.ISP.QuebrandoRegra.Cliente();
            Interfaces.SOLID.ISP.QuebrandoRegra.IGenerica produto = new Interfaces.SOLID.ISP.QuebrandoRegra.Produto();
            Interfaces.SOLID.ISP.QuebrandoRegra.IGenerica fornecedor = new Interfaces.SOLID.ISP.QuebrandoRegra.Fornecedor();

            Salvar(clienteISP);
            Salvar(produto);
            Salvar(fornecedor);

            //Solução
            Interfaces.SOLID.ISP.Solucao.IPagamento clienteISP2 = new Interfaces.SOLID.ISP.Solucao.Cliente();
            Interfaces.SOLID.ISP.Solucao.IGenerica produto2 = new Interfaces.SOLID.ISP.Solucao.Produto();
            Interfaces.SOLID.ISP.Solucao.IPagamento fornecedor2 = new Interfaces.SOLID.ISP.Solucao.Fornecedor();
                                                                                       
            Salvar2(clienteISP2);
            Salvar2(produto2);
            Salvar2(fornecedor2);

            //Solução 2
            Interfaces.SOLID.ISP.Solucao2.IPagamento clienteISP3 = new Interfaces.SOLID.ISP.Solucao2.Cliente();
            Interfaces.SOLID.ISP.Solucao2.IGenerica produto3 = new Interfaces.SOLID.ISP.Solucao2.Produto();
            Interfaces.SOLID.ISP.Solucao2.IPagamento fornecedor3 = new Interfaces.SOLID.ISP.Solucao2.Fornecedor();

            Salvar3(clienteISP3);
            Salvar3(produto3);
            Salvar3(fornecedor3);

            // SOLID - DIP
            // Solução 1 - Utilizando dependência de interface
            var clienteDIP = new Interfaces.SOLID.DIP.Solucao.Cliente();
            clienteDIP.Nome = "Lucas";
            clienteDIP.Telefone = "12342365367";
            try
            {
                new Interfaces.SOLID.DIP.Solucao.Validacao().Validar(clienteDIP);
                //Interfaces.SOLID.DIP.Solucao.IRepositorio repositorio = new Interfaces.SOLID.DIP.Solucao.Repositorio();
                Interfaces.SOLID.DIP.Solucao.IRepositorio repositorio = new Interfaces.SOLID.DIP.Solucao.RepositorioEmTexto(); // Agora não existe acoplamento forte, pois agora depende da interface
                repositorio.Salvar(ref clienteDIP);
                //Interfaces.SOLID.DIP.Solucao.ISms smsSender = new Interfaces.SOLID.DIP.Solucao.SmsOi(); // Solução 2 - Utilizando injeção de dependência 
                Interfaces.SOLID.DIP.Solucao.ISms smsSender = new Interfaces.SOLID.DIP.Solucao.SmsVivo(); // Solução 2 - Utilizando injeção de dependência 
                new Interfaces.SOLID.DIP.Solucao.Sms().Enviar(clienteDIP, smsSender);
            }                        
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao validar a mensagem {ex.Message}");
            }


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

        // overload
        private static void Salvar3(SOLID.ISP.Solucao2.IPagamento pagamento)
        {
            pagamento.Pagar();
        }
        private static void Salvar3(SOLID.ISP.Solucao2.IGenerica generica)
        {
            generica.Id = 1;
            generica.Salvar();
        }
        
        // overload
        private static void Salvar2(SOLID.ISP.Solucao.IPagamento pagamento)
        {
            pagamento.Id = 1;
            pagamento.Salvar();
        }
        private static void Salvar2(SOLID.ISP.Solucao.IGenerica generica)
        {
            generica.Id = 1;
            generica.Salvar();
        }


        private static void Salvar(IGenerica generica)
        {
            generica.Id = 1;
            generica.Salvar();
        }
    }
}
