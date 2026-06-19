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
            clientes = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            btnExcluirCliente = new Button();
            btnEditarCliente = new Button();
            lstClientes = new ListBox();
            btnCadastrarCliente = new Button();
            txtContatoCliente = new TextBox();
            txtNomeCliente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnExcluirItem = new Button();
            btnEditarItem = new Button();
            lstItens = new ListBox();
            btnCadastrarItem = new Button();
            label6 = new Label();
            txtComponentesIniciais = new TextBox();
            txtValorDiario = new TextBox();
            txtNomeItem = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tabPage3 = new TabPage();
            btnRemoverPeca = new Button();
            btnAplicarUpgrade = new Button();
            lstPecasAtuais = new ListBox();
            label5 = new Label();
            cmbSetupsUpgrade = new ComboBox();
            tabPage4 = new TabPage();
            btnExcluirLocacao = new Button();
            lstLocacoes = new ListBox();
            btnDevolver = new Button();
            btnRegistrarLocacao = new Button();
            dtpDevolucao = new DateTimePicker();
            dtpRetirada = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            cmbItens = new ComboBox();
            cmbClientes = new ComboBox();
            tabUsuarios = new TabPage();
            lstUsuarios = new ListBox();
            btnCadastrarUsuario = new Button();
            cmbPapelUsuario = new ComboBox();
            lblPapelUsuario = new Label();
            txtSenhaUsuario = new TextBox();
            txtLoginUsuario = new TextBox();
            lblSenhaUsuario = new Label();
            lblLoginUsuario = new Label();
            txtNomeUsuario = new TextBox();
            txtNomeDoUsuario = new Label();
            lblNomeUsuario = new Label();
            tabPage5 = new TabPage();
            btnLogout = new MaterialSkin.Controls.MaterialButton();
            tabMetricas = new TabPage();
            lblTotalSetups = new MaterialSkin.Controls.MaterialLabel();
            lblLocacoesAtivas = new MaterialSkin.Controls.MaterialLabel();
            lblTotalClientes = new MaterialSkin.Controls.MaterialLabel();
            clientes.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabUsuarios.SuspendLayout();
            tabPage5.SuspendLayout();
            tabMetricas.SuspendLayout();
            SuspendLayout();
            // 
            // clientes
            // 
            clientes.Controls.Add(tabPage1);
            clientes.Controls.Add(tabPage2);
            clientes.Controls.Add(tabPage3);
            clientes.Controls.Add(tabPage4);
            clientes.Controls.Add(tabUsuarios);
            clientes.Controls.Add(tabPage5);
            clientes.Controls.Add(tabMetricas);
            clientes.Depth = 0;
            clientes.ImeMode = ImeMode.On;
            clientes.Location = new Point(2, 66);
            clientes.Margin = new Padding(3, 2, 3, 2);
            clientes.MouseState = MaterialSkin.MouseState.HOVER;
            clientes.Multiline = true;
            clientes.Name = "clientes";
            clientes.SelectedIndex = 0;
            clientes.Size = new Size(915, 383);
            clientes.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnExcluirCliente);
            tabPage1.Controls.Add(btnEditarCliente);
            tabPage1.Controls.Add(lstClientes);
            tabPage1.Controls.Add(btnCadastrarCliente);
            tabPage1.Controls.Add(txtContatoCliente);
            tabPage1.Controls.Add(txtNomeCliente);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(907, 355);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "clientes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCliente
            // 
            btnExcluirCliente.Location = new Point(208, 315);
            btnExcluirCliente.Name = "btnExcluirCliente";
            btnExcluirCliente.Size = new Size(211, 41);
            btnExcluirCliente.TabIndex = 3;
            btnExcluirCliente.Text = "Excluir Cliente";
            btnExcluirCliente.UseVisualStyleBackColor = true;
            btnExcluirCliente.Click += btnExcluirCliente_Click;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.Location = new Point(208, 259);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(211, 41);
            btnEditarCliente.TabIndex = 3;
            btnEditarCliente.Text = "Editar Cliente";
            btnEditarCliente.UseVisualStyleBackColor = true;
            btnEditarCliente.Click += btnEditarCliente_Click;
            // 
            // lstClientes
            // 
            lstClientes.Location = new Point(469, 34);
            lstClientes.Margin = new Padding(3, 2, 3, 2);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(233, 349);
            lstClientes.TabIndex = 0;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Location = new Point(208, 205);
            btnCadastrarCliente.Margin = new Padding(3, 2, 3, 2);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(211, 40);
            btnCadastrarCliente.TabIndex = 2;
            btnCadastrarCliente.Text = "cadastrar cliente";
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // txtContatoCliente
            // 
            txtContatoCliente.Location = new Point(303, 170);
            txtContatoCliente.Margin = new Padding(3, 2, 3, 75);
            txtContatoCliente.Name = "txtContatoCliente";
            txtContatoCliente.PlaceholderText = "(99) 9 9999-9999";
            txtContatoCliente.Size = new Size(117, 23);
            txtContatoCliente.TabIndex = 1;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(303, 130);
            txtNomeCliente.Margin = new Padding(3, 2, 3, 2);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.PlaceholderText = "guilherme...";
            txtNomeCliente.Size = new Size(117, 23);
            txtNomeCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 175);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "contato";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 132);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "nome";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnExcluirItem);
            tabPage2.Controls.Add(btnEditarItem);
            tabPage2.Controls.Add(lstItens);
            tabPage2.Controls.Add(btnCadastrarItem);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txtComponentesIniciais);
            tabPage2.Controls.Add(txtValorDiario);
            tabPage2.Controls.Add(txtNomeItem);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(907, 355);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "setups";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExcluirItem
            // 
            btnExcluirItem.Location = new Point(364, 365);
            btnExcluirItem.Name = "btnExcluirItem";
            btnExcluirItem.Size = new Size(82, 23);
            btnExcluirItem.TabIndex = 5;
            btnExcluirItem.Text = "Excluir Setup";
            btnExcluirItem.UseVisualStyleBackColor = true;
            btnExcluirItem.Click += btnExcluirItem_Click;
            // 
            // btnEditarItem
            // 
            btnEditarItem.Location = new Point(364, 336);
            btnEditarItem.Name = "btnEditarItem";
            btnEditarItem.Size = new Size(82, 23);
            btnEditarItem.TabIndex = 5;
            btnEditarItem.Text = "Editar Setup";
            btnEditarItem.UseVisualStyleBackColor = true;
            btnEditarItem.Click += btnEditarItem_Click;
            // 
            // lstItens
            // 
            lstItens.FormattingEnabled = true;
            lstItens.Location = new Point(486, 39);
            lstItens.Margin = new Padding(3, 2, 3, 2);
            lstItens.Name = "lstItens";
            lstItens.Size = new Size(132, 349);
            lstItens.TabIndex = 4;
            // 
            // btnCadastrarItem
            // 
            btnCadastrarItem.Location = new Point(364, 309);
            btnCadastrarItem.Margin = new Padding(3, 2, 3, 2);
            btnCadastrarItem.Name = "btnCadastrarItem";
            btnCadastrarItem.Size = new Size(82, 22);
            btnCadastrarItem.TabIndex = 3;
            btnCadastrarItem.Text = "cadastrar";
            btnCadastrarItem.UseVisualStyleBackColor = true;
            btnCadastrarItem.Click += btnCadastrarItem_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(204, 122);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 2;
            label6.Text = "componentes";
            // 
            // txtComponentesIniciais
            // 
            txtComponentesIniciais.Location = new Point(350, 122);
            txtComponentesIniciais.Margin = new Padding(3, 2, 3, 2);
            txtComponentesIniciais.Multiline = true;
            txtComponentesIniciais.Name = "txtComponentesIniciais";
            txtComponentesIniciais.PlaceholderText = "RTX 5070, 32gb DDR5";
            txtComponentesIniciais.Size = new Size(110, 174);
            txtComponentesIniciais.TabIndex = 1;
            // 
            // txtValorDiario
            // 
            txtValorDiario.Location = new Point(350, 87);
            txtValorDiario.Margin = new Padding(3, 2, 3, 2);
            txtValorDiario.Name = "txtValorDiario";
            txtValorDiario.PlaceholderText = "R$ 10,00";
            txtValorDiario.Size = new Size(110, 23);
            txtValorDiario.TabIndex = 1;
            // 
            // txtNomeItem
            // 
            txtNomeItem.Location = new Point(350, 52);
            txtNomeItem.Margin = new Padding(3, 2, 3, 2);
            txtNomeItem.Name = "txtNomeItem";
            txtNomeItem.PlaceholderText = "SETUP 1 ";
            txtNomeItem.Size = new Size(110, 23);
            txtNomeItem.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(204, 87);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 0;
            label4.Text = "Valor Diário (R$)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 58);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 0;
            label3.Text = "Nome do PC";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnRemoverPeca);
            tabPage3.Controls.Add(btnAplicarUpgrade);
            tabPage3.Controls.Add(lstPecasAtuais);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(cmbSetupsUpgrade);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(907, 355);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "upgrade";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRemoverPeca
            // 
            btnRemoverPeca.Location = new Point(377, 278);
            btnRemoverPeca.Name = "btnRemoverPeca";
            btnRemoverPeca.Size = new Size(133, 59);
            btnRemoverPeca.TabIndex = 4;
            btnRemoverPeca.Text = "Remover Peça Selecionada";
            btnRemoverPeca.UseVisualStyleBackColor = true;
            btnRemoverPeca.Click += btnRemoverPeca_Click;
            // 
            // btnAplicarUpgrade
            // 
            btnAplicarUpgrade.Location = new Point(377, 194);
            btnAplicarUpgrade.Margin = new Padding(3, 2, 3, 2);
            btnAplicarUpgrade.Name = "btnAplicarUpgrade";
            btnAplicarUpgrade.Size = new Size(133, 64);
            btnAplicarUpgrade.TabIndex = 3;
            btnAplicarUpgrade.Text = "aplicar";
            btnAplicarUpgrade.UseVisualStyleBackColor = true;
            btnAplicarUpgrade.Click += btnAplicarUpgrade_Click_1;
            // 
            // lstPecasAtuais
            // 
            lstPecasAtuais.FormattingEnabled = true;
            lstPecasAtuais.Location = new Point(174, 105);
            lstPecasAtuais.Margin = new Padding(3, 2, 3, 2);
            lstPecasAtuais.Name = "lstPecasAtuais";
            lstPecasAtuais.Size = new Size(132, 184);
            lstPecasAtuais.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(395, 118);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 1;
            label5.Text = "selecione o pc";
            label5.Visible = false;
            // 
            // cmbSetupsUpgrade
            // 
            cmbSetupsUpgrade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSetupsUpgrade.FormattingEnabled = true;
            cmbSetupsUpgrade.Location = new Point(377, 145);
            cmbSetupsUpgrade.Margin = new Padding(3, 2, 3, 2);
            cmbSetupsUpgrade.Name = "cmbSetupsUpgrade";
            cmbSetupsUpgrade.Size = new Size(133, 23);
            cmbSetupsUpgrade.TabIndex = 0;
            cmbSetupsUpgrade.SelectedIndexChanged += cmbSetupsUpgrade_SelectedIndexChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnExcluirLocacao);
            tabPage4.Controls.Add(lstLocacoes);
            tabPage4.Controls.Add(btnDevolver);
            tabPage4.Controls.Add(btnRegistrarLocacao);
            tabPage4.Controls.Add(dtpDevolucao);
            tabPage4.Controls.Add(dtpRetirada);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(cmbItens);
            tabPage4.Controls.Add(cmbClientes);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 2, 3, 2);
            tabPage4.Size = new Size(907, 355);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "locações e devoluções";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnExcluirLocacao
            // 
            btnExcluirLocacao.Location = new Point(621, 251);
            btnExcluirLocacao.Name = "btnExcluirLocacao";
            btnExcluirLocacao.Size = new Size(232, 23);
            btnExcluirLocacao.TabIndex = 5;
            btnExcluirLocacao.Text = "Excluir Locação";
            btnExcluirLocacao.UseVisualStyleBackColor = true;
            btnExcluirLocacao.Click += btnExcluirLocacao_Click;
            // 
            // lstLocacoes
            // 
            lstLocacoes.FormattingEnabled = true;
            lstLocacoes.Location = new Point(403, 49);
            lstLocacoes.Margin = new Padding(3, 2, 3, 2);
            lstLocacoes.Name = "lstLocacoes";
            lstLocacoes.Size = new Size(132, 244);
            lstLocacoes.TabIndex = 4;
            // 
            // btnDevolver
            // 
            btnDevolver.Location = new Point(621, 171);
            btnDevolver.Margin = new Padding(3, 2, 3, 2);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(232, 22);
            btnDevolver.TabIndex = 3;
            btnDevolver.Text = "registrar devolucao";
            btnDevolver.UseVisualStyleBackColor = true;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // btnRegistrarLocacao
            // 
            btnRegistrarLocacao.Location = new Point(151, 220);
            btnRegistrarLocacao.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarLocacao.Name = "btnRegistrarLocacao";
            btnRegistrarLocacao.Size = new Size(198, 54);
            btnRegistrarLocacao.TabIndex = 3;
            btnRegistrarLocacao.Text = "registrar";
            btnRegistrarLocacao.UseVisualStyleBackColor = true;
            btnRegistrarLocacao.Click += btnRegistrarLocacao_Click;
            // 
            // dtpDevolucao
            // 
            dtpDevolucao.Format = DateTimePickerFormat.Short;
            dtpDevolucao.Location = new Point(713, 124);
            dtpDevolucao.Margin = new Padding(3, 2, 3, 2);
            dtpDevolucao.Name = "dtpDevolucao";
            dtpDevolucao.Size = new Size(130, 23);
            dtpDevolucao.TabIndex = 2;
            // 
            // dtpRetirada
            // 
            dtpRetirada.Format = DateTimePickerFormat.Short;
            dtpRetirada.Location = new Point(228, 177);
            dtpRetirada.Margin = new Padding(3, 2, 3, 2);
            dtpRetirada.Name = "dtpRetirada";
            dtpRetirada.Size = new Size(130, 23);
            dtpRetirada.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(625, 128);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 1;
            label10.Text = "data dev.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(139, 182);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 1;
            label9.Text = "data inicio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(139, 131);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 1;
            label8.Text = "setup";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(139, 82);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 1;
            label7.Text = "cliente";
            // 
            // cmbItens
            // 
            cmbItens.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItens.FormattingEnabled = true;
            cmbItens.Location = new Point(225, 125);
            cmbItens.Margin = new Padding(3, 2, 3, 2);
            cmbItens.Name = "cmbItens";
            cmbItens.Size = new Size(133, 23);
            cmbItens.TabIndex = 0;
            // 
            // cmbClientes
            // 
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(225, 80);
            cmbClientes.Margin = new Padding(3, 2, 3, 2);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(133, 23);
            cmbClientes.TabIndex = 0;
            // 
            // tabUsuarios
            // 
            tabUsuarios.Controls.Add(lstUsuarios);
            tabUsuarios.Controls.Add(btnCadastrarUsuario);
            tabUsuarios.Controls.Add(cmbPapelUsuario);
            tabUsuarios.Controls.Add(lblPapelUsuario);
            tabUsuarios.Controls.Add(txtSenhaUsuario);
            tabUsuarios.Controls.Add(txtLoginUsuario);
            tabUsuarios.Controls.Add(lblSenhaUsuario);
            tabUsuarios.Controls.Add(lblLoginUsuario);
            tabUsuarios.Controls.Add(txtNomeUsuario);
            tabUsuarios.Controls.Add(txtNomeDoUsuario);
            tabUsuarios.Controls.Add(lblNomeUsuario);
            tabUsuarios.Location = new Point(4, 24);
            tabUsuarios.Name = "tabUsuarios";
            tabUsuarios.Padding = new Padding(3);
            tabUsuarios.Size = new Size(907, 355);
            tabUsuarios.TabIndex = 4;
            tabUsuarios.Text = "usuários";
            tabUsuarios.UseVisualStyleBackColor = true;
            tabUsuarios.Click += tabUsuarios_Click;
            // 
            // lstUsuarios
            // 
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.Location = new Point(397, 43);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(120, 214);
            lstUsuarios.TabIndex = 8;
            // 
            // btnCadastrarUsuario
            // 
            btnCadastrarUsuario.Location = new Point(235, 234);
            btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            btnCadastrarUsuario.Size = new Size(100, 23);
            btnCadastrarUsuario.TabIndex = 7;
            btnCadastrarUsuario.Text = "Cadastrar Usuário";
            btnCadastrarUsuario.UseVisualStyleBackColor = true;
            btnCadastrarUsuario.Click += btnCadastrarUsuario_Click;
            // 
            // cmbPapelUsuario
            // 
            cmbPapelUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPapelUsuario.FormattingEnabled = true;
            cmbPapelUsuario.Location = new Point(235, 189);
            cmbPapelUsuario.Name = "cmbPapelUsuario";
            cmbPapelUsuario.Size = new Size(100, 23);
            cmbPapelUsuario.TabIndex = 6;
            // 
            // lblPapelUsuario
            // 
            lblPapelUsuario.AutoSize = true;
            lblPapelUsuario.Location = new Point(178, 192);
            lblPapelUsuario.Name = "lblPapelUsuario";
            lblPapelUsuario.Size = new Size(36, 15);
            lblPapelUsuario.TabIndex = 5;
            lblPapelUsuario.Text = "Papel";
            // 
            // txtSenhaUsuario
            // 
            txtSenhaUsuario.Location = new Point(235, 146);
            txtSenhaUsuario.Name = "txtSenhaUsuario";
            txtSenhaUsuario.PasswordChar = '●';
            txtSenhaUsuario.Size = new Size(100, 23);
            txtSenhaUsuario.TabIndex = 4;
            // 
            // txtLoginUsuario
            // 
            txtLoginUsuario.Location = new Point(235, 98);
            txtLoginUsuario.Name = "txtLoginUsuario";
            txtLoginUsuario.Size = new Size(100, 23);
            txtLoginUsuario.TabIndex = 3;
            // 
            // lblSenhaUsuario
            // 
            lblSenhaUsuario.AutoSize = true;
            lblSenhaUsuario.Location = new Point(176, 146);
            lblSenhaUsuario.Name = "lblSenhaUsuario";
            lblSenhaUsuario.Size = new Size(38, 15);
            lblSenhaUsuario.TabIndex = 2;
            lblSenhaUsuario.Text = "senha";
            lblSenhaUsuario.Click += lblLoginUsuario_Click;
            // 
            // lblLoginUsuario
            // 
            lblLoginUsuario.AutoSize = true;
            lblLoginUsuario.Location = new Point(176, 101);
            lblLoginUsuario.Name = "lblLoginUsuario";
            lblLoginUsuario.Size = new Size(37, 15);
            lblLoginUsuario.TabIndex = 2;
            lblLoginUsuario.Text = "Login";
            lblLoginUsuario.Click += lblLoginUsuario_Click;
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Location = new Point(235, 54);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(100, 23);
            txtNomeUsuario.TabIndex = 1;
            // 
            // txtNomeDoUsuario
            // 
            txtNomeDoUsuario.AutoSize = true;
            txtNomeDoUsuario.Location = new Point(391, 54);
            txtNomeDoUsuario.Name = "txtNomeDoUsuario";
            txtNomeDoUsuario.Size = new Size(0, 15);
            txtNomeDoUsuario.TabIndex = 0;
            txtNomeDoUsuario.Click += lblNomeUsuario_Click;
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Location = new Point(186, 54);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(40, 15);
            lblNomeUsuario.TabIndex = 0;
            lblNomeUsuario.Text = "Nome";
            lblNomeUsuario.Click += lblNomeUsuario_Click;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(btnLogout);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(907, 355);
            tabPage5.TabIndex = 5;
            tabPage5.Text = "SAIR";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogout.Depth = 0;
            btnLogout.HighEmphasis = true;
            btnLogout.Icon = null;
            btnLogout.Location = new Point(375, 136);
            btnLogout.Margin = new Padding(4, 6, 4, 9);
            btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogout.Name = "btnLogout";
            btnLogout.NoAccentTextColor = Color.Empty;
            btnLogout.Size = new Size(64, 36);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "SAIR";
            btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogout.UseAccentColor = false;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // tabMetricas
            // 
            tabMetricas.Controls.Add(lblTotalSetups);
            tabMetricas.Controls.Add(lblLocacoesAtivas);
            tabMetricas.Controls.Add(lblTotalClientes);
            tabMetricas.Location = new Point(4, 24);
            tabMetricas.Name = "tabMetricas";
            tabMetricas.Padding = new Padding(3);
            tabMetricas.Size = new Size(907, 355);
            tabMetricas.TabIndex = 6;
            tabMetricas.Text = "RESUMO";
            tabMetricas.UseVisualStyleBackColor = true;
            // 
            // lblTotalSetups
            // 
            lblTotalSetups.AutoSize = true;
            lblTotalSetups.Depth = 0;
            lblTotalSetups.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTotalSetups.Location = new Point(352, 174);
            lblTotalSetups.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotalSetups.Name = "lblTotalSetups";
            lblTotalSetups.Size = new Size(83, 19);
            lblTotalSetups.TabIndex = 0;
            lblTotalSetups.Text = "A calcular...";
            // 
            // lblLocacoesAtivas
            // 
            lblLocacoesAtivas.AutoSize = true;
            lblLocacoesAtivas.Depth = 0;
            lblLocacoesAtivas.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblLocacoesAtivas.Location = new Point(352, 137);
            lblLocacoesAtivas.MouseState = MaterialSkin.MouseState.HOVER;
            lblLocacoesAtivas.Name = "lblLocacoesAtivas";
            lblLocacoesAtivas.Size = new Size(83, 19);
            lblLocacoesAtivas.TabIndex = 0;
            lblLocacoesAtivas.Text = "A calcular...";
            // 
            // lblTotalClientes
            // 
            lblTotalClientes.AutoSize = true;
            lblTotalClientes.Depth = 0;
            lblTotalClientes.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTotalClientes.Location = new Point(352, 99);
            lblTotalClientes.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotalClientes.Name = "lblTotalClientes";
            lblTotalClientes.Size = new Size(83, 19);
            lblTotalClientes.TabIndex = 0;
            lblTotalClientes.Text = "A calcular...";
            lblTotalClientes.Click += materialLabel1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 450);
            Controls.Add(clientes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Padding = new Padding(3, 48, 3, 2);
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
            tabUsuarios.ResumeLayout(false);
            tabUsuarios.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabMetricas.ResumeLayout(false);
            tabMetricas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl clientes;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox txtContatoCliente;
        private TextBox txtNomeCliente;
        private Label label2;
        private Label label1;
        private Button btnCadastrarCliente;
        private ListBox lstClientes;
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
        private DateTimePicker dtpDevolucao;
        private DateTimePicker dtpRetirada;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnAplicarUpgrade;
 
        private ListBox lstPecasAtuais;
        private Button btnExcluirCliente;
        private Button btnEditarCliente;
        private Button btnExcluirItem;
        private Button btnEditarItem;
        private Button btnRemoverPeca;
        private Button btnExcluirLocacao;
        private TabPage tabUsuarios;
        private TextBox txtNomeUsuario;
        private Label lblNomeUsuario;
        private Label txtNomeDoUsuario;
        private TextBox txtSenhaUsuario;
        private TextBox txtLoginUsuario;
        private Label lblLoginUsuario;
        private Label lblSenhaUsuario;
        private ComboBox cmbPapelUsuario;
        private Label lblPapelUsuario;
        private ListBox lstUsuarios;
        private Button btnCadastrarUsuario;
        private TabPage tabPage5;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private TabPage tabMetricas;
        private MaterialSkin.Controls.MaterialLabel lblTotalSetups;
        private MaterialSkin.Controls.MaterialLabel lblLocacoesAtivas;
        private MaterialSkin.Controls.MaterialLabel lblTotalClientes;
    }
}
