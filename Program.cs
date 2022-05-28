using System;
using System.Collections.Generic;
using aula2.calculadoras;
using aula2.concatenacao;
using aula2.ordenacao;

namespace aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region calculadora 
            // string valorA;
            // string valorB;
            // Console.WriteLine("Digite o valor A :");
            // valorA = Console.ReadLine();
            // Console.WriteLine("Digite o valor B :");
            // valorB = Console.ReadLine();
            // var calc = new calculadora();
            // var resultado = calc.add(Convert.ToInt16(valorB),Convert.ToInt16(valorA));
            // Console.WriteLine("resultado :" + resultado);
            // Console.ReadLine();
            #endregion


            #region order//NOME
            //var concatenar = new concatenar();
            //string nome;
            //string sobrenome;
            //Console.WriteLine("Digite seu nome :");
            //nome = Console.ReadLine();
            //Console.WriteLine("Digite seu sobrenome :");
            //sobrenome = Console.ReadLine();
            //var nomecompleto = concatenar.nomecompleto(nome, sobrenome);
            //var QtdCaracter = concatenar.QtdCaracter(nome,sobrenome);
            //Console.WriteLine("resultado :" + concatenar.(nome, sobrenome));
            //Console.WriteLine("resultado :" +concatenar.QtdCaracter (nome,sobrenome));
            //Console.ReadLine();
            #endregion
            #region ordenacao
            var nomes = new List<string>();
            nomes.Add("Pedro");
            nomes.Add("Ana");
            nomes.Add("João");
            nomes.Add("Maria");

            var orde = new ordenar();
            var resultado = orde.order(nomes);
            foreach (var nome in resultado)
            {
                Console.WriteLine(nome);
            }
            #endregion



        }
    }
}
