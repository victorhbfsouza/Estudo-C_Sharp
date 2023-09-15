using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    public class Carro
    {
        #region Atributos
        public string Modelo {get; set;}
        public string Cor {get; set;}
        public int Ano {get; set;}

        #endregion

        #region Construtores
        //Construtor Padrão
        public Carro()
        {
        }

        //Construtor Personalisado
        public Carro(string modelo, string cor, int ano)
        {
        Modelo = modelo;
        Cor = cor;
        Ano = ano;
        }

        #endregion

        #region Métodos

        public void LigarCarro()
        {
            Console.WriteLine("Carro ligando.......");
            Console.WriteLine("Carro ligado!");
        }

        public void tocarBuzina()
        {
        Console.WriteLine("BIIIIII");
        }

        #endregion


  }

}