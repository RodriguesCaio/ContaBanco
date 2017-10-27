using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.ContaBanco.Class
{
    public class Operacao
    {
        public double OpSaque(double SaldoPessoa, double Valor)
        {
            SaldoPessoa = SaldoPessoa - Valor;
            return SaldoPessoa;
        }
        public double OpDeposito(double SaldoPessoa, double Valor)
        {
            SaldoPessoa = SaldoPessoa + Valor;
            return SaldoPessoa;
        }
    }
}
