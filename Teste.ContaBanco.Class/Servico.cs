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
        {       //int count = null;
            foreach (Class.Pessoa item  in listadeconta)
            {
                    
                if (item.NumeroConta == pessoa.NumeroConta)
                {
                    RetSaldo = item.SaldoEmConta;
                    //listadeconta[i].saque ou 
                }
                else
                {
                    listadeconta.Add(pessoa);
                }
                //count++;
               
            }
            return RetSaldo;
        }

        public int FoundAccount (ref List<Class.Pessoa> listadeconta, Pessoa pessoa)
        {
            int count=0;
            foreach (Pessoa item in listadeconta)
            {
                if (item.NumeroConta == pessoa.NumeroConta)
                {
                    listadeconta[count].Deposito(valor);
                    return count;
                }
                count++;
            }
            return count;
        }
    }
}
