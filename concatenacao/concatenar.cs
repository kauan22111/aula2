using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2.concatenacao
{
    internal class concatenar
    {
        public string nomecompleto(string nome, string sobrenome)
        {
          
            return nome +"   "+ sobrenome;
        }
        public int QtdCaracter(string nome,string sobrenome)
        {
            return nome.Length + sobrenome.Length;
        }
            

    }
}
