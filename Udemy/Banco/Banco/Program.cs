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
            Console.WriteLine("============ Bem vindo(a) ao Banco ============");
            Console.WriteLine("===============================================\n");

            var titular01 = new Titular("Victor Hugo", "123.456.789.10", "24-2233-4455, endereco");
            var titular02 = new Titular("Calebe Cleiton", "123.456.789.10", "24-2233-4455, endereco");


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

            var conta02 = new ContaBancaria(titular02);

            try
            {
                var valor = conta01.Sacar(1001);
                Console.WriteLine(valor);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //Console.WriteLine("Nome do cliente: " + titular01.Nome + "\nSaldo R$" + conta01.Saldo + "\nEndereço: " + titular01.Endereco.Rua + " n." + titular01.Endereco.Numero);
            Console.WriteLine("Saldo conta 01 R$" + conta01.Saldo);
            Console.WriteLine("Saldo conta 02 R$" + conta02.Saldo);

            Console.ReadLine();
        }
    }
}
