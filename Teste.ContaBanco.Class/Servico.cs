using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.ContaBanco.Class
{
    public class Servico
    {
        public double ValidaConta(Pessoa pessoa , List<Class.Pessoa> listadeconta, double RetSaldo)
        {
            foreach (Class.Pessoa item  in listadeconta)
            {
                if (item.NumeroConta == pessoa.NumeroConta)
                {
                    RetSaldo = item.SaldoEmConta;
                }
                else
                {
                    listadeconta.Add(pessoa);
                }
               
            }
            return RetSaldo;
        }
    }
}
