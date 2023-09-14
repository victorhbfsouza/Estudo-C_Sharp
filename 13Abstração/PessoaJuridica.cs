using System;

class PessoaJuridica : Padrao
{
    //Método Obrigatório
    public override void taxaEmprestimo (double valor)
    {
        Console.WriteLine("Taxa de empréstimo para pessoa jurídica R$" +(valor*0.2));
    }
}