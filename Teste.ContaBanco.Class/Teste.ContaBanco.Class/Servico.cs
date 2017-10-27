using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.ContaBanco.Class
{
    public class Servico
    {
        public int ValidaConta(int NumContaPessoa, List<int> listadeconta)
        {
            foreach (int conta in listadeconta)
            {
                if (conta == NumContaPessoa)
                {
                    //return 1;
                    var x = conta;
                }

            }
            return 0;
        }
    }
}
