using System;

class Aluno
{
    //Atributos
    public string nome;
    public double nota1, nota2;

    //Métodos
    //Média
    public double media()
    {
        return (nota1+nota2)/2;
    }

    public string situacao(double media)
    {
        return media >= 7 ? "Aprovado" : "Reprovado";
    }

    public void mensagem()
    {
        double obterMedia = media();

        string obterSituacao = situacao(obterMedia);

        Console.WriteLine("O aluno(a) " + nome + " está " + obterSituacao + " com a média " + obterMedia + ".");
    }

}