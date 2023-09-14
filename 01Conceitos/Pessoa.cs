using System;

class Pessoa
{
    //Atributos
    public string nome;
    public int idade;

    //Métodos
    public void Mensagem()
    {
        Console.WriteLine("Olá " + nome + " vocêm " + idade + " anos.");
    }
}
