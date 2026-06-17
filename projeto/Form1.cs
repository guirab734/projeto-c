using System;
using System.Collections.Generic;
using System.Windows.Forms;
using projeto.Models;
using projeto.Repositories;

namespace projeto
{//oi
    public partial class Form1 : Form
    {
        // Bancos de dados temporários na memória
        private List<Item> listaItens = new List<Item>();
        private List<Locacao> listaLocacoes = new List<Locacao>();

        public Form1()
        {
            InitializeComponent();

            // Ativa o banco de dados
            projeto.Data.DatabaseConnection.InicializarBanco();

            // Configura os textos exibidos
            cmbClientes.DisplayMember = "Nome";
            cmbItens.DisplayMember = "Nome";
            cmbSetupsUpgrade.DisplayMember = "Nome";

            lstClientes.DisplayMember = "Nome";
            lstItens.DisplayMember = "Nome";

            // Carrega os clientes salvos do banco
            AtualizarListasClientes();

            // Dá o start nas listas de setups e locações (mesmo que vazias no início)
            AtualizarListasItens();
            AtualizarListagemLocacoes();
        }

        private void AtualizarListasClientes()
        {
            try
            {
                ClienteRepository repo = new ClienteRepository();
                List<Cliente> listaDoBanco = repo.ObterTodos();

                // Atualiza o ListBox e o ComboBox da tela
                lstClientes.DataSource = null;
                lstClientes.DataSource = listaDoBanco;

                cmbClientes.DataSource = null;
                cmbClientes.DataSource = listaDoBanco;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do banco: " + ex.Message);
            }
        }

        // CLIENTES - Cadastrar
        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {
                MessageBox.Show("Por favor, insira o nome do cliente.");
                return;
            }

            try
            {
                Cliente novoCliente = new Cliente(txtNomeCliente.Text, txtContatoCliente.Text);
                ClienteRepository repo = new ClienteRepository();
                repo.Salvar(novoCliente);

                MessageBox.Show("Cliente salvo no banco de dados!");

                txtNomeCliente.Clear();
                txtContatoCliente.Clear();
                AtualizarListasClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }


        }

        // SETUP - Cadastrar
        private void btnCadastrarItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeItem.Text) || !decimal.TryParse(txtValorDiario.Text, out decimal valorDiario))
            {
                MessageBox.Show("Insira um nome válido e um valor de diária numérico.");
                return;
            }

            Item novoItem = new Item(txtNomeItem.Text, valorDiario);

            if (!string.IsNullOrWhiteSpace(txtComponentesIniciais.Text))
            {
                string[] pecas = txtComponentesIniciais.Text.Split(',');
                foreach (var peca in pecas)
                {
                    novoItem.Componentes.Add(peca.Trim());
                }
            }


            listaItens.Add(novoItem);
            AtualizarListasItens();

            txtNomeItem.Clear();
            txtValorDiario.Clear();
            txtComponentesIniciais.Clear();
            MessageBox.Show("Setup de hardware cadastrado com sucesso!");
        }

        private void AtualizarListasItens()
        {
            // Criamos uma lista de exibição que garante que o nome seja pego corretamente
            // Isso evita que o Windows Forms se perca tentando ler o objeto complexo

            // Para o ListBox
            lstItens.DataSource = null;
            lstItens.Items.Clear();
            foreach (var item in listaItens)
            {
                lstItens.Items.Add(item.Nome); // Adicionamos apenas o nome como texto
            }

            // Para o ComboBox de Itens
            cmbItens.DataSource = null;
            cmbItens.Items.Clear();
            foreach (var item in listaItens)
            {
                cmbItens.Items.Add(item.Nome);
            }

            // Para o ComboBox de Upgrades
            cmbSetupsUpgrade.DataSource = null;
            cmbSetupsUpgrade.Items.Clear();
            foreach (var item in listaItens)
            {
                cmbSetupsUpgrade.Items.Add(item.Nome);
            }
        }

        // LOCAÇÃO - Registrar
        private void btnRegistrarLocacao_Click(object sender, EventArgs e)
        {
            projeto.Models.Cliente clienteSel = (projeto.Models.Cliente)cmbClientes.SelectedItem;
            projeto.Models.Item itemSel = (projeto.Models.Item)cmbItens.SelectedItem;

            if (clienteSel == null || itemSel == null)
            {
                MessageBox.Show("Selecione um cliente e um setup válidos.");
                return;
            }

            Locacao novaLocacao = new Locacao(clienteSel, itemSel, dtpRetirada.Value, dtpDevolucao.Value);
            listaLocacoes.Add(novaLocacao);

            AtualizarListagemLocacoes();
            MessageBox.Show($"Locação salva com sucesso!\nValor Total: R$ {novaLocacao.ValorTotal:N2}");
        }

        // LOCAÇÃO - Devolver
        private void btnDevolver_Click(object sender, EventArgs e)
        {
            int index = lstLocacoes.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Selecione uma locação ativa na lista para realizar a devolução.");
                return;
            }

            List<Locacao> ativas = listaLocacoes.FindAll(l => l.Ativa);
            if (index < ativas.Count)
            {
                ativas[index].RegistrarDevolucao();
                AtualizarListagemLocacoes();
                MessageBox.Show("Devolução concluída! O equipamento retornou ao estoque.");
            }
        }

        private void AtualizarListagemLocacoes()
        {
            // Filtra apenas as locações que ainda estão ativas
            List<Locacao> ativas = listaLocacoes.FindAll(l => l.Ativa);

            lstLocacoes.DataSource = null;
            lstLocacoes.DataSource = ativas; // O ToString que colocamos na classe Locacao vai cuidar do texto!
        }

        // UPGRADE - Mudança de PC
        private void cmbSetupsUpgrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item setupSel = (Item)cmbSetupsUpgrade.SelectedItem;
            if (setupSel != null)
            {
                lstPecasAtuais.Items.Clear();
                foreach (var peca in setupSel.Componentes)
                {
                    lstPecasAtuais.Items.Add(peca);
                }
            }
        }

        // UPGRADE - Aplicar Peça Nova (Conectado com o Designer _1)
        private void btnAplicarUpgrade_Click_1(object sender, EventArgs e)
        {
            Item setupSel = (Item)cmbSetupsUpgrade.SelectedItem;
            if (setupSel == null)
            {
                MessageBox.Show("Selecione um setup para aplicar o upgrade.");
                return;
            }

            string pecaTexto = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome da nova peça para o Upgrade:", "Novo Componente", "");

            if (string.IsNullOrWhiteSpace(pecaTexto)) return;

            bool estaAlugado = listaLocacoes.Exists(l => l.Item == setupSel && l.Ativa);
            if (estaAlugado)
            {
                MessageBox.Show("❌ Bloqueado! Este computador está atualmente alugado por um cliente.", "Aviso");
                return;
            }

            setupSel.Componentes.Add(pecaTexto.Trim());
            cmbSetupsUpgrade_SelectedIndexChanged(this, EventArgs.Empty);
            MessageBox.Show("⚡ Upgrade concluído com sucesso!");
        }
    }
}