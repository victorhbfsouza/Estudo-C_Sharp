using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    public class Moto
    {
        #region Atributos
        public string Modelo {get; set;}

        public string Cor {get; set;}

        public string Marca {get; set;}

        public int Ano {get; set;}

        public int Cilindradas {get; set;}

        #endregion

        #region Construtores
        //Contrutor Padrão
        public Moto()
        {
        }

        //Construtor Personalizado
        public Moto (string marca, string modelo, string cor, int ano, int cilindradas){
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
            Cilindradas = cilindradas;
        }
        #endregion
    }
}