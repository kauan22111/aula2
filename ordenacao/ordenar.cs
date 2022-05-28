using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2.ordenacao
{

    public class ordenar
    {
        public List<string> order(List<string> w)
        {
            return w.OrderBy(c =>c).ToList();
        }

    }

}
