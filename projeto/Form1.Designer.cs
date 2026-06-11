namespace projeto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clientes = new TabControl();
            tabPage1 = new TabPage();
            clientes_cadastrados = new ListBox();
            btnCadastrarCliente = new Button();
            txtContatoCliente = new TextBox();
            txtNomeCliente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            lstItens = new ListBox();
            btnCadastrarItem = new Button();
            label6 = new Label();
            txtComponentesIniciais = new TextBox();
            txtValorDiario = new TextBox();
            txtNomeItem = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tabPage3 = new TabPage();
            label5 = new Label();
            cmbSetupsUpgrade = new ComboBox();
            tabPage4 = new TabPage();
            lstLocacoes = new ListBox();
            btnDevolver = new Button();
            btnRegistrarLocacao = new Button();
            dateTimePicker1 = new DateTimePicker();
            dtpRetirada = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            cmbItens = new ComboBox();
            cmbClientes = new ComboBox();
            lstPecasAtuais = new ListBox();
            txtNovaPeca = new ListBox();
            btnAplicarUpgrade = new Button();
            clientes.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // clientes
            // 
            clientes.Controls.Add(tabPage1);
            clientes.Controls.Add(tabPage2);
            clientes.Controls.Add(tabPage3);
            clientes.Controls.Add(tabPage4);
            clientes.ImeMode = ImeMode.On;
            clientes.Location = new Point(2, 12);
            clientes.Name = "clientes";
            clientes.SelectedIndex = 0;
            clientes.Size = new Size(1046, 587);
            clientes.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(clientes_cadastrados);
            tabPage1.Controls.Add(btnCadastrarCliente);
            tabPage1.Controls.Add(txtContatoCliente);
            tabPage1.Controls.Add(txtNomeCliente);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1038, 554);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "clientes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // clientes_cadastrados
            // 
            clientes_cadastrados.Location = new Point(536, 46);
            clientes_cadastrados.Name = "clientes_cadastrados";
            clientes_cadastrados.Size = new Size(266, 464);
            clientes_cadastrados.TabIndex = 0;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Location = new Point(238, 273);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(241, 54);
            btnCadastrarCliente.TabIndex = 2;
            btnCadastrarCliente.Text = "cadastrar cliente";
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            //btnCadastrarCliente.Click += button1_Click;
            // 
            // txtContatoCliente
            // 
            txtContatoCliente.Location = new Point(346, 226);
            txtContatoCliente.Margin = new Padding(3, 3, 3, 100);
            txtContatoCliente.Name = "txtContatoCliente";
            txtContatoCliente.PlaceholderText = "(99) 9 9999-9999";
            txtContatoCliente.Size = new Size(133, 27);
            txtContatoCliente.TabIndex = 1;
            //txtContatoCliente.TextChanged += txtContatoCliente_TextChanged;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(346, 173);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.PlaceholderText = "guilherme...";
            txtNomeCliente.Size = new Size(133, 27);
            txtNomeCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 233);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 0;
            label2.Text = "contato";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 176);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "nome";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lstItens);
            tabPage2.Controls.Add(btnCadastrarItem);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txtComponentesIniciais);
            tabPage2.Controls.Add(txtValorDiario);
            tabPage2.Controls.Add(txtNomeItem);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1038, 554);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "setups";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstItens
            // 
            lstItens.FormattingEnabled = true;
            lstItens.Location = new Point(718, 35);
            lstItens.Name = "lstItens";
            lstItens.Size = new Size(150, 104);
            lstItens.TabIndex = 4;
            // 
            // btnCadastrarItem
            // 
            btnCadastrarItem.Location = new Point(221, 387);
            btnCadastrarItem.Name = "btnCadastrarItem";
            btnCadastrarItem.Size = new Size(94, 29);
            btnCadastrarItem.TabIndex = 3;
            btnCadastrarItem.Text = "button1";
            btnCadastrarItem.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 120);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 2;
            label6.Text = "componentes";
            //label6.Click += label6_Click;
            // 
            // txtComponentesIniciais
            // 
            txtComponentesIniciais.Location = new Point(216, 120);
            txtComponentesIniciais.Multiline = true;
            txtComponentesIniciais.Name = "txtComponentesIniciais";
            txtComponentesIniciais.Size = new Size(125, 231);
            txtComponentesIniciais.TabIndex = 1;
            //txtComponentesIniciais.TextChanged += textBox1_TextChanged;
            // 
            // txtValorDiario
            // 
            txtValorDiario.Location = new Point(216, 73);
            txtValorDiario.Name = "txtValorDiario";
            txtValorDiario.PlaceholderText = "R$ 10,00";
            txtValorDiario.Size = new Size(125, 27);
            txtValorDiario.TabIndex = 1;
            // 
            // txtNomeItem
            // 
            txtNomeItem.Location = new Point(216, 27);
            txtNomeItem.Name = "txtNomeItem";
            txtNomeItem.PlaceholderText = "SETUP 1 ";
            txtNomeItem.Size = new Size(125, 27);
            txtNomeItem.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 73);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 0;
            label4.Text = "Valor Diário (R$)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 34);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 0;
            label3.Text = "Nome do PC";
            //label3.Click += label3_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnAplicarUpgrade);
            tabPage3.Controls.Add(txtNovaPeca);
            tabPage3.Controls.Add(lstPecasAtuais);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(cmbSetupsUpgrade);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1038, 554);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "upgrade";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 105);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 1;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // cmbSetupsUpgrade
            // 
            cmbSetupsUpgrade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSetupsUpgrade.FormattingEnabled = true;
            cmbSetupsUpgrade.Location = new Point(30, 40);
            cmbSetupsUpgrade.Name = "cmbSetupsUpgrade";
            cmbSetupsUpgrade.Size = new Size(151, 28);
            cmbSetupsUpgrade.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(lstLocacoes);
            tabPage4.Controls.Add(btnDevolver);
            tabPage4.Controls.Add(btnRegistrarLocacao);
            tabPage4.Controls.Add(dateTimePicker1);
            tabPage4.Controls.Add(dtpRetirada);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(cmbItens);
            tabPage4.Controls.Add(cmbClientes);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1038, 554);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "locações e devoluções";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // lstLocacoes
            // 
            lstLocacoes.FormattingEnabled = true;
            lstLocacoes.Location = new Point(711, 46);
            lstLocacoes.Name = "lstLocacoes";
            lstLocacoes.Size = new Size(150, 104);
            lstLocacoes.TabIndex = 4;
            // 
            // btnDevolver
            // 
            btnDevolver.Location = new Point(309, 357);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(265, 29);
            btnDevolver.TabIndex = 3;
            btnDevolver.Text = "registrar devolucao";
            btnDevolver.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarLocacao
            // 
            btnRegistrarLocacao.Location = new Point(113, 357);
            btnRegistrarLocacao.Name = "btnRegistrarLocacao";
            btnRegistrarLocacao.Size = new Size(94, 29);
            btnRegistrarLocacao.TabIndex = 3;
            btnRegistrarLocacao.Text = "registrar";
            btnRegistrarLocacao.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(207, 261);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(148, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // dtpRetirada
            // 
            dtpRetirada.Format = DateTimePickerFormat.Short;
            dtpRetirada.Location = new Point(207, 194);
            dtpRetirada.Name = "dtpRetirada";
            dtpRetirada.Size = new Size(148, 27);
            dtpRetirada.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(106, 266);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 1;
            label10.Text = "data dev.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(106, 201);
            label9.Name = "label9";
            label9.Size = new Size(95, 20);
            label9.TabIndex = 1;
            label9.Text = "data retirada";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(106, 133);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 1;
            label8.Text = "setups";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(106, 68);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 1;
            label7.Text = "clientes";
            // 
            // cmbItens
            // 
            cmbItens.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItens.FormattingEnabled = true;
            cmbItens.Location = new Point(204, 125);
            cmbItens.Name = "cmbItens";
            cmbItens.Size = new Size(151, 28);
            cmbItens.TabIndex = 0;
            // 
            // cmbClientes
            // 
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(204, 65);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(151, 28);
            cmbClientes.TabIndex = 0;
            // 
            // lstPecasAtuais
            // 
            lstPecasAtuais.FormattingEnabled = true;
            lstPecasAtuais.Location = new Point(285, 71);
            lstPecasAtuais.Name = "lstPecasAtuais";
            lstPecasAtuais.Size = new Size(150, 104);
            lstPecasAtuais.TabIndex = 2;
            // 
            // txtNovaPeca
            // 
            txtNovaPeca.FormattingEnabled = true;
            txtNovaPeca.Location = new Point(285, 233);
            txtNovaPeca.Name = "txtNovaPeca";
            txtNovaPeca.Size = new Size(150, 104);
            txtNovaPeca.TabIndex = 2;
            // 
            // btnAplicarUpgrade
            // 
            btnAplicarUpgrade.Location = new Point(302, 398);
            btnAplicarUpgrade.Name = "btnAplicarUpgrade";
            btnAplicarUpgrade.Size = new Size(94, 29);
            btnAplicarUpgrade.TabIndex = 3;
            btnAplicarUpgrade.Text = "button1";
            btnAplicarUpgrade.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 600);
            Controls.Add(clientes);
            Name = "Form1";
            Text = "Form1";
            clientes.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl clientes;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox txtContatoCliente;
        private TextBox txtNomeCliente;
        private Label label2;
        private Label label1;
        private Button btnCadastrarCliente;
        private ListBox clientes_cadastrados;
        private Label label4;
        private Label label3;
        private TextBox txtValorDiario;
        private TextBox txtNomeItem;
        private TabPage tabPage4;
        private Label label5;
        private ComboBox cmbSetupsUpgrade;
        private Label label6;
        private TextBox txtComponentesIniciais;
        private ListBox lstItens;
        private Button btnCadastrarItem;
        private Label label7;
        private ComboBox cmbItens;
        private ComboBox cmbClientes;
        private ListBox lstLocacoes;
        private Button btnDevolver;
        private Button btnRegistrarLocacao;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dtpRetirada;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnAplicarUpgrade;
        private ListBox txtNovaPeca;
        private ListBox lstPecasAtuais;
    }
}
