using System;

class Imposto
{
    //Métodos (para sobreescrever é necessário escrever virtual antes do retorno do método, e onde sobreescrever também é necessário fazer anotação)
    public virtual void valeAlimentação(double salario)
    {
        Console.WriteLine("Desconto padrão do vale alimentação R$" + (salario *0.1));
    }

        public void valeTransporte(double salario)
    {
        Console.WriteLine("Desconto padrão do vale transporte R$" + (salario *0.06));
    }
}