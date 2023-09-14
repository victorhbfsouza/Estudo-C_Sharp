using System;

class Atendente : Imposto
{
        //Método (para sobreescrever o método, é necessário colocar o override antes do retorno dela)
    public override void valeAlimentação(double salario)
    {
        Console.WriteLine("Desconto atendente do vale alimentação R$" + (salario *0.12));
    }

}