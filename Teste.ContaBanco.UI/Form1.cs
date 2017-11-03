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
        List<Class.Pessoa> lstClientes = new List<Class.Pessoa>();

        double SaldoCliente;
        string Opcao;
        double ReturnSaldo;

        private void btnEfetuar_Click(object sender, EventArgs e)
        {
            pessoa = new Pessoa();
            pessoa.Nome = txtNome.Text;
            pessoa.NumeroConta = Convert.ToInt32(txtNumConta.Text);
            pessoa.CPF = Convert.ToInt32(txtCPF.Text);

           
            servico = new Servico();
            servico.ValidaConta(pessoa, lstClientes, ReturnSaldo);

            
            
            operacao = new Operacao();
            if (chkSaque.Checked)
            {
                pessoa.SaldoEmConta =  operacao.OpSaque(ReturnSaldo, Convert.ToDouble(txtValor.Text));
                Opcao = "Saque";
            }
            else if (chkDeposito.Checked)
            {
                pessoa.SaldoEmConta = operacao.OpDeposito(ReturnSaldo, Convert.ToDouble(txtValor.Text));
                Opcao = "Depósito";
            }

            lstExtrato.Items.Add(lstClientes);

            lstExtrato.Items.Add(pessoa.Nome + " | " + "Numero da conta: " +
                pessoa.NumeroConta + " | " + Opcao + " | Valor: " + Convert.ToDouble(txtValor.Text)
                + " | Saldo em conta: " + pessoa.SaldoEmConta);
        }
    }
}
