using System;

namespace _03ExercicioEscolar;

class Program
{
    static void Main(string[] args)
    {
        // Instanciando objeto da classe aluno
        Aluno a = new Aluno();
        a.nome = "Victor";
        a.nota1 = 9;
        a.nota2 = 8;
        a.mensagem();
        
    }
}
