﻿using Interfaces.SOLID.OCP.QuebrandoRegra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.SOLID.OCP.Solucao
{
    public class Juridica : IPessoa, IJuridica
    {
        public Juridica() { }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }

        public void Salvar()
        {
            Console.WriteLine("Salvando Jurídica");
        }
    }
}