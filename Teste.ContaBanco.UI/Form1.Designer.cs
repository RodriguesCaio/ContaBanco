namespace Teste.ContaBanco.UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumConta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.chkSaque = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkDeposito = new System.Windows.Forms.CheckBox();
            this.btnEfetuar = new System.Windows.Forms.Button();
            this.lstExtrato = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(133, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero da Conta";
            // 
            // txtNumConta
            // 
            this.txtNumConta.Location = new System.Drawing.Point(15, 76);
            this.txtNumConta.Name = "txtNumConta";
            this.txtNumConta.Size = new System.Drawing.Size(87, 20);
            this.txtNumConta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(12, 128);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(123, 20);
            this.txtCPF.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(226, 25);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 7;
            // 
            // chkSaque
            // 
            this.chkSaque.AutoSize = true;
            this.chkSaque.Location = new System.Drawing.Point(226, 83);
            this.chkSaque.Name = "chkSaque";
            this.chkSaque.Size = new System.Drawing.Size(57, 17);
            this.chkSaque.TabIndex = 8;
            this.chkSaque.Text = "Saque";
            this.chkSaque.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Operação";
            // 
            // chkDeposito
            // 
            this.chkDeposito.AutoSize = true;
            this.chkDeposito.Location = new System.Drawing.Point(226, 106);
            this.chkDeposito.Name = "chkDeposito";
            this.chkDeposito.Size = new System.Drawing.Size(68, 17);
            this.chkDeposito.TabIndex = 10;
            this.chkDeposito.Text = "Depósito";
            this.chkDeposito.UseVisualStyleBackColor = true;
            // 
            // btnEfetuar
            // 
            this.btnEfetuar.Location = new System.Drawing.Point(226, 129);
            this.btnEfetuar.Name = "btnEfetuar";
            this.btnEfetuar.Size = new System.Drawing.Size(100, 33);
            this.btnEfetuar.TabIndex = 11;
            this.btnEfetuar.Text = "Efetuar";
            this.btnEfetuar.UseVisualStyleBackColor = true;
            this.btnEfetuar.Click += new System.EventHandler(this.btnEfetuar_Click);
            // 
            // lstExtrato
            // 
            this.lstExtrato.FormattingEnabled = true;
            this.lstExtrato.Location = new System.Drawing.Point(12, 168);
            this.lstExtrato.Name = "lstExtrato";
            this.lstExtrato.Size = new System.Drawing.Size(503, 342);
            this.lstExtrato.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 522);
            this.Controls.Add(this.lstExtrato);
            this.Controls.Add(this.btnEfetuar);
            this.Controls.Add(this.chkDeposito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkSaque);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumConta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumConta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.CheckBox chkSaque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkDeposito;
        private System.Windows.Forms.Button btnEfetuar;
        private System.Windows.Forms.ListBox lstExtrato;
    }
}

