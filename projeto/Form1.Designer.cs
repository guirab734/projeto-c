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
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            label1 = new Label();
            label2 = new Label();
            txtNomeCliente = new TextBox();
            txtContatoCliente = new TextBox();
            btnCadastrarCliente = new Button();
            clientes_cadastrados = new ListBox();
            label3 = new Label();
            label4 = new Label();
            txtNomeItem = new TextBox();
            txtValorDiario = new TextBox();
            tabPage4 = new TabPage();
            comboBox1 = new ComboBox();
            label5 = new Label();
            clientes.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
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
            // tabPage2
            // 
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
            // tabPage3
            // 
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(comboBox1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1038, 554);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "upgrade";
            tabPage3.UseVisualStyleBackColor = true;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 233);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 0;
            label2.Text = "contato";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(346, 173);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.PlaceholderText = "guilherme...";
            txtNomeCliente.Size = new Size(133, 27);
            txtNomeCliente.TabIndex = 1;
            // 
            // txtContatoCliente
            // 
            txtContatoCliente.Location = new Point(346, 226);
            txtContatoCliente.Margin = new Padding(3, 3, 3, 100);
            txtContatoCliente.Name = "txtContatoCliente";
            txtContatoCliente.PlaceholderText = "(99) 9 9999-9999";
            txtContatoCliente.Size = new Size(133, 27);
            txtContatoCliente.TabIndex = 1;
            txtContatoCliente.TextChanged += txtContatoCliente_TextChanged;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Location = new Point(238, 273);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(241, 54);
            btnCadastrarCliente.TabIndex = 2;
            btnCadastrarCliente.Text = "cadastrar cliente";
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            btnCadastrarCliente.Click += button1_Click;
            // 
            // clientes_cadastrados
            // 
            clientes_cadastrados.Location = new Point(536, 46);
            clientes_cadastrados.Name = "clientes_cadastrados";
            clientes_cadastrados.Size = new Size(266, 464);
            clientes_cadastrados.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 34);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 0;
            label3.Text = "Nome do PC";
            label3.Click += label3_Click;
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
            // txtNomeItem
            // 
            txtNomeItem.Location = new Point(216, 27);
            txtNomeItem.Name = "txtNomeItem";
            txtNomeItem.PlaceholderText = "SETUP 1 ";
            txtNomeItem.Size = new Size(125, 27);
            txtNomeItem.TabIndex = 1;
            // 
            // txtValorDiario
            // 
            txtValorDiario.Location = new Point(216, 73);
            txtValorDiario.Name = "txtValorDiario";
            txtValorDiario.PlaceholderText = "R$ 10,00";
            txtValorDiario.Size = new Size(125, 27);
            txtValorDiario.TabIndex = 1;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1038, 554);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "locações e devoluções";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(30, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
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
        private ComboBox comboBox1;
    }
}
