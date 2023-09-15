using Banco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("============= Bem vindo(a) ao Banco ===========");
            Console.WriteLine("===============================================\n");

            var titular01 = new Titular("Victor Hugo", "123.456.789.10", "24-2233-4455");

            titular01.Endereco = new Endereco
            {
                Cep = "25.620-050",
                Rua = "Rua Dr. Alencar Lima",
                Numero = 20,
                Bairro = "Centro",
                Cidade = "Petrópolis",
                UF = "RJ",
            };

            var conta01 = new ContaBancaria(titular01, 100.00);

            Console.WriteLine("Nome do cliente: " + titular01.Nome + "\nSaldo R$" + conta01.Saldo + "\nEndereço: " + titular01.Endereco.Rua + " n." + titular01.Endereco.Numero);

            Console.ReadLine();
        }
    }
}
