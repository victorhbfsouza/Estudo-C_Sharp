using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    public class Pessoa
    {
        // Tipos de propriedade de Atributos e Métodos
        // public qualquer pessoa pode acessar
        // private somente aquela classe pode acessar
        // protected somente a classe que criou ou que herdar ela pode acessar

        public string Nome {get; set;}

        public string Sobrenome {get; set;}

        public string NomeCompleto => Nome + Sobrenome;

        public int Idade {get; set;}

        //NÃO é necessário criar o método abaixo, basta no atributo incluir ( => Nome + Sobrenome;)

        // public string NomeTodo()
        // {
        //     return NomeCompleto = Nome + " " + Sobrenome;
        // }
        
    }
}