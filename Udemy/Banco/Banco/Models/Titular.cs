using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Models
{
    internal class Titular
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }

        public Titular(string nome, string cpf, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = Telefone;
        }
    }
}
