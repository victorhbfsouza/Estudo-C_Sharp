using System;

class Pessoa
{

    //Construtor
    public Pessoa()
    {
        Console.WriteLine("Contrutor executado");
    }


    public Pessoa(string nome)
    {
        Console.WriteLine("Olá " + nome);
    }

}