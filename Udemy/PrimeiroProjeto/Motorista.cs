using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrimeiroProjeto;

namespace PrimeiroProjeto
{
    public class Motorista : Pessoa
    {
        public string CategoriaHabilitacao {get; set;}

        // Neste caso o construtor constou somente categoria pois ele é filho da classe Pessoa,
        // portanto já possuindo os atributos da referida classe como nome, sobrenome e etc...

        public Motorista()
        {
            
        }

    }
}