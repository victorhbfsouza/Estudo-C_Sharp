using System;

class Aluno
{
    private double nota1, nota2;

    private double media()
    {
        return (nota1+nota2)/2;
    }

    public void mensagem()
    {
        Console.WriteLine("Informe a primeira nota :");
        nota1 = Convert.ToInt32(console.ReadLine());
        Console.WriteLine("Informe a segunda nota: ");
        nota2 = Convert.ToInt32(console.ReadLine());
        Console.WriteLine("A média entre as notas informadas é: " + media);
    }
}