using System;
using System.Collections.Generic;
using System.Windows.Forms;
using projeto.Models;

namespace projeto
{
    public partial class Form1 : Form
    {
        // Bancos de dados temporários na memória
        private List<Cliente> listaClientes = new List<Cliente>();
        private List<Item> listaItens = new List<Item>();
        private List<Locacao> listaLocacoes = new List<Locacao>();

        public Form1()
        {
            InitializeComponent();

            // Configura como os objetos serão exibidos nas caixas de seleção
            cmbClientes.DisplayMember = "Nome";
            cmbItens.DisplayMember = "Nome";
            cmbSetupsUpgrade.DisplayMember = "Nome";

            lstClientes.DisplayMember = "Nome";
            lstItens.DisplayMember = "Nome";
        }

        // CLIENTES
        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {
                MessageBox.Show("Por favor, insira o nome do cliente.");
                return;
            }

            projeto.Models.Cliente novoCliente = new projeto.Models.Cliente(txtNomeCliente.Text, txtContatoCliente.Text);

            listaClientes.Add(novoCliente);
            AtualizarListasClientes();

            txtNomeCliente.Clear();
            txtContatoCliente.Clear();
            MessageBox.Show("Cliente cadastrado com sucesso!");
        }
        private void AtualizarListasClientes()
        {
            lstClientes.DataSource = null;
            lstClientes.DataSource = listaClientes;

            cmbClientes.DataSource = null;
            cmbClientes.DataSource = listaClientes;
        }

        // SETUP
        private void btnCadastrarItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeItem.Text) || !decimal.TryParse(txtValorDiario.Text, out decimal valorDiario))
            {
                MessageBox.Show("Insira um nome válido e um valor de diária numérico.");
                return;
            }

            Item novoItem = new Item(txtNomeItem.Text, valorDiario);

            // Pega as peças digitadas separadas por vírgula
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
            lstItens.DataSource = null;
            lstItens.DataSource = listaItens;

            cmbItens.DataSource = null;
            cmbItens.DataSource = listaItens;

            cmbSetupsUpgrade.DataSource = null;
            cmbSetupsUpgrade.DataSource = listaItens;
        }

        // locação
        private void btnRegistrarLocacao_Click(object sender, EventArgs e)
        {
            Cliente clienteSel = (Cliente)cmbClientes.SelectedItem;
            Item itemSel = (Item)cmbItens.SelectedItem;

            if (clienteSel == null || itemSel == null)
            {
                MessageBox.Show("Selecione um cliente e um setup válidos.");
                return;
            }

            // Cria a locação passando as datas
            Locacao novaLocacao = new Locacao(clienteSel, itemSel, dtpRetirada.Value, dtpDevolucao.Value);
            listaLocacoes.Add(novaLocacao);

            AtualizarListagemLocacoes();
            MessageBox.Show($"Locação salva com sucesso!\nValor Total: R$ {novaLocacao.ValorTotal:N2}");
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            int index = lstLocacoes.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Selecione uma locação ativa na lista para realizar a devolução.");
                return;
            }

            // Filtra apenas as locações que ainda estão ativas na memória
            List<Locacao> ativas = listaLocacoes.FindAll(l => l.Ativa);
            if (index < ativas.Count)
            {
                // Altera o estado interno usando encapsulamento
                ativas[index].RegistrarDevolucao();
                AtualizarListagemLocacoes();
                MessageBox.Show("Devolução concluída! O equipamento retornou ao estoque.");
            }
        }

        private void AtualizarListagemLocacoes()
        {
            lstLocacoes.Items.Clear();
            foreach (var locacao in listaLocacoes)
            {
                // Só exibe na lista o que ainda estiver alugado (Ativa == true)
                if (locacao.Ativa)
                {
                    lstLocacoes.Items.Add($"{locacao.Cliente.Nome} -> {locacao.Item.Nome} (Total: R$ {locacao.ValorTotal:N2})");
                }
            }
        }

        // UPGRADE 

        private void cmbSetupsUpgrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item setupSel = (Item)cmbSetupsUpgrade.SelectedItem;
            if (setupSel != null)
            {
                lstPecasAtuais.Items.Clear();
            }
            foreach (var peca in setupSel.Componentes)
            {
                lstPecasAtuais.Items.Add(peca);
            }
        }

        private void btnAplicarUpgrade_Click(object sender, EventArgs e)
        {
            Item setupSel = (Item)cmbSetupsUpgrade.SelectedItem;
            if (setupSel == null)
            {
                MessageBox.Show("Selecione um setup para aplicar o upgrade.");
                return;
            }

            // SLECIONAR SE HOUVER PARA UPGREDAR

            string pecaTexto = txtNovaPeca.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(pecaTexto))
            {
                // Caso queira digitar na hora se a lista estiver vazia:
                pecaTexto = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome da nova peça para o Upgrade:", "Novo Componente", "");
            }

            if (string.IsNullOrWhiteSpace(pecaTexto)) return;

            //Verifica se o item possui alguma locação ativa

            bool estaAlugado = listaLocacoes.Exists(l => l.Item == setupSel && l.Ativa);
            if (estaAlugado)
            {
                MessageBox.Show("❌ Bloqueado! Este computador está atualmente alugado por um cliente.\n" +
                                "O upgrade só é permitido quando o equipamento retornar para o estoque.",
                                "Validação de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se o hardware estiver livre, adiciona a peça na lista interna do objeto
            setupSel.Componentes.Add(pecaTexto.Trim());

            // Atualiza a lista na tela para mostrar a peça nova imediatamente
            cmbSetupsUpgrade_SelectedIndexChanged(this, EventArgs.Empty);
            MessageBox.Show($"⚡ Upgrade concluído! Nova peça instalada com sucesso no {setupSel.Nome}.");
        }
    }
}