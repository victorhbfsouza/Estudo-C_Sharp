using System;

class Pessoa
{
    private string nome = "Hugo";

    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}