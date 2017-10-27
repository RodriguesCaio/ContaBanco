using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste.ContaBanco.Class;
using System.Collections;

namespace Teste.ContaBanco.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pessoa pessoa;
        Servico servico;
        Operacao operacao;

        double SaldoCliente;
        string Opcao;

        private void btnEfetuar_Click(object sender, EventArgs e)
        {
            pessoa = new Pessoa();
            pessoa.Nome = txtNome.Text;
            pessoa.NumeroConta = Convert.ToInt32(txtNumConta.Text);
            pessoa.CPF = Convert.ToInt32(txtCPF.Text);

            List<int> lstNumConta = new List<int>();
            lstNumConta.Add(pessoa.NumeroConta);

            servico = new Servico();
            servico.ValidaConta(pessoa.NumeroConta, lstNumConta);

            operacao = new Operacao();
            if (chkSaque.Checked)
            {
                SaldoCliente =  operacao.OpSaque(SaldoCliente, Convert.ToDouble(txtValor.Text));
                Opcao = "Saque";
            }
            else if (chkDeposito.Checked)
            {
                SaldoCliente = operacao.OpDeposito(SaldoCliente, Convert.ToDouble(txtValor.Text));
                Opcao = "Depósito";
            }

            lstExtrato.Items.Add(pessoa.Nome + " | " + "Numero da conta: " +
                pessoa.NumeroConta + " | " + Opcao + " | Valor: " + Convert.ToDouble(txtValor.Text)
                + " | Saldo em conta: " + SaldoCliente);
        }
    }
}
