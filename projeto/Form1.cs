using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using projeto.Models;
using projeto.Repositories;
using projeto.Services;

namespace projeto
{
    public partial class Form1 : Form
    {
        private readonly ClienteService _clienteService = new ClienteService();
        private readonly ItemService _itemService = new ItemService();
        private readonly LocacaoService _locacaoService = new LocacaoService();
        private readonly UsuarioService _usuarioService = new UsuarioService();
        // Guarda o cliente/item atualmente selecionado na lista, para os
        // botões de Editar/Excluir saberem sobre qual registro agir.
        private Cliente _clienteSelecionado = null;
        private Item _itemSelecionado = null;

        public Form1()
        {
            InitializeComponent();

            cmbClientes.DisplayMember = "Nome";
            cmbItens.DisplayMember = "Nome";
            cmbSetupsUpgrade.DisplayMember = "Nome";

            lstClientes.DisplayMember = "Nome";
            lstItens.DisplayMember = "Nome";

            AtualizarListasClientes();
            AtualizarListasItens();
            AtualizarListagemLocacoes();

            // NOVO: configura e carrega a aba de usuários
            cmbPapelUsuario.DisplayMember = "Nome";
            lstUsuarios.DisplayMember = "Nome";
            CarregarPapeis();
            AtualizarListaUsuarios();

            // Conecta os eventos de seleção nas listas (preenche os campos
            // automaticamente quando o usuário clica num item da lista)
            lstClientes.SelectedIndexChanged += lstClientes_SelectedIndexChanged;
            lstItens.SelectedIndexChanged += lstItens_SelectedIndexChanged;

            AplicarPermissoesDeTela();
        }

        // ===================== RBAC NA TELA =====================
        private void AplicarPermissoesDeTela()
        {
            bool podeEscrever = SessaoUsuario.PodeEscreverNoDominio;

            btnCadastrarCliente.Enabled = podeEscrever;
            btnEditarCliente.Enabled = podeEscrever;
            btnExcluirCliente.Enabled = podeEscrever;

            btnCadastrarItem.Enabled = podeEscrever;
            btnEditarItem.Enabled = podeEscrever;
            btnExcluirItem.Enabled = podeEscrever;

            btnRegistrarLocacao.Enabled = podeEscrever;
            btnDevolver.Enabled = podeEscrever;
            btnExcluirLocacao.Enabled = podeEscrever;

            btnAplicarUpgrade.Enabled = podeEscrever;
            btnRemoverPeca.Enabled = podeEscrever;
        }

        // ===================== CLIENTES =====================
        private void AtualizarListasClientes()
        {
            try
            {
                List<Cliente> listaDoBanco = _clienteService.ObterTodos();

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

        // Quando o usuário clica num cliente na lista, preenche os campos
        // de texto com os dados dele — assim Editar/Excluir sabem o alvo.
        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _clienteSelecionado = lstClientes.SelectedItem as Cliente;
            if (_clienteSelecionado != null)
            {
                txtNomeCliente.Text = _clienteSelecionado.Nome;
                txtContatoCliente.Text = _clienteSelecionado.Contato;
            }
        }

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
                _clienteService.Salvar(novoCliente);

                MessageBox.Show("Cliente salvo no banco de dados!");

                txtNomeCliente.Clear();
                txtContatoCliente.Clear();
                AtualizarListasClientes();
            }
            catch (AcessoNegadoException ex)
            {
                MessageBox.Show(ex.Message, "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        // CLIENTE - Editar
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (_clienteSelecionado == null)
            {
                MessageBox.Show("Selecione um cliente na lista para editar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {
                MessageBox.Show("O nome não pode ficar vazio.");
                return;
            }

            try
            {
                _clienteSelecionado.Nome = txtNomeCliente.Text;
                _clienteSelecionado.Contato = txtContatoCliente.Text;
                _clienteService.Atualizar(_clienteSelecionado);

                MessageBox.Show("Cliente atualizado com sucesso!");
                AtualizarListasClientes();
            }
            catch (AcessoNegadoException ex)
            {
                MessageBox.Show(ex.Message, "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
        }

        // CLIENTE - Excluir
        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            if (_clienteSelecionado == null)
            {
                MessageBox.Show("Selecione um cliente na lista para excluir.");
                return;
            }

            var confirmacao = MessageBox.Show(
                $"Tem certeza que deseja excluir o cliente '{_clienteSelecionado.Nome}'?",
                "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao != DialogResult.Yes) return;

            try
            {
                _clienteService.Excluir(_clienteSelecionado.Id);

                MessageBox.Show("Cliente excluído com sucesso!");
                txtNomeCliente.Clear();
                txtContatoCliente.Clear();
                _clienteSelecionado = null;
                AtualizarListasClientes();
            }
            catch (AcessoNegadoException ex)
            {
                MessageBox.Show(ex.Message, "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }

        // ===================== SETUPS (ITEM) =====================
        private void AtualizarListasItens()
        {
            try
            {
                List<Item> listaDoBanco = _itemService.ObterTodos();

                lstItens.DataSource = null;
                lstItens.DataSource = listaDoBanco;

                cmbItens.DataSource = null;
                cmbItens.DataSource = listaDoBanco;

                cmbSetupsUpgrade.DataSource = null;
                cmbSetupsUpgrade.DataSource = listaDoBanco;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar setups do banco: " + ex.Message);
            }
        }

        private void lstItens_SelectedIndexChanged(object sender, EventArgs e)
        {
            _itemSelecionado = lstItens.SelectedItem as Item;
            if (_itemSelecionado != null)
            {
                txtNomeItem.Text = _itemSelecionado.Nome;
                txtValorDiario.Text = _itemSelecionado.ValorDiario.ToString();
                txtComponentesIniciais.Text = string.Join(", ", _itemSelecionado.Componentes);
            }
        }

        private void btnCadastrarItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeItem.Text) || !decimal.TryParse(txtValorDiario.Text, out decimal valorDiario))
            {
                MessageBox.Show("Insira um nome válido e um valor de diária numérico.");
                return;
            }

            try
            {
                Item novoItem = new Item(txtNomeItem.Text, valorDiario);

                if (!string.IsNullOrWhiteSpace(txtComponentesIniciais.Text))
                {
                    string[] pecas = txtComponentesIniciais.Text.Split(',');
                    foreach (var peca in pecas)
                    {
                        novoItem.Componentes.Add(peca.Trim());
                    }
                }

                _itemService.Salvar(novoItem);
                AtualizarListasItens();

                txtNomeItem.Clear();
                txtValorDiario.Clear();
                txtComponentesIniciais.Clear();
                MessageBox.Show("Setup de hardware cadastrado com sucesso!");
            }
            catch (AcessoNegadoException ex)
            {
                MessageBox.Show(ex.Message, "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar setup: " + ex.Message);
            }
        }

        // SETUP - Editar (nome e valor diário; componentes são tratados na aba Upgrade)
        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            if (_itemSelecionado == null)
            {
                MessageBox.Show("Selecione um setup na lista para editar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNomeItem.Text) || !decimal.TryParse(txtValorDiario.Text, out decimal valorDiario))
            {
                MessageBox.Show("Insira um nome válido e um valor de diária numérico.");
                return;
            }

            try
            {
                _itemSelecionado.Nome = txtNomeItem.Text;
                _itemSelecionado.ValorDiario = valorDiario;
                _itemService.Atualizar(_itemSelecionado);

                MessageBox.Show("Setup atualizado com sucesso!");
                AtualizarListasItens();
            }
            catch (AcessoNegadoException ex)
            {
                MessageBox.Show(ex.Message, "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar setup: " + ex.Message);
            }
        }

        // SETUP - Excluir
        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            if (_itemSelecionado == null)
            {
                MessageBox.Show("Selecione um setup na lista para excluir.");
                return;
            }

            var confirmacao = MessageBox.Show(
                $"Tem certeza que deseja excluir o setup '{_itemSelecionado.Nome}'?",
                "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao != DialogResult.Yes) return;

            try
            {
                _itemService.Excluir(_itemSelecionado.Id);

                MessageBox.Show("Setup excluído com sucesso!");
                txtNomeItem.Clear();
                txtValorDiario.Clear();
                txtComponentesIniciais.Clear();
                _itemSelecionado = null;
                AtualizarListasItens();
            }
            catch (AcessoNegadoException ex)
            {
                MessageBox.Show(ex.Message, "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir setup: " + ex.Message);
            }
        }

        // ===================== LOCAÇÕES =====================
        private void btnRegistrarLocacao_Click(object sender, EventArgs e)
        {
            Cliente clienteSel = (Cliente)cmbClientes.SelectedItem;
            Item itemSel = (Item)cmbItens.SelectedItem;

            if (clienteSel == null || itemSel == null)
            {
                MessageBox.Show("Selecione um cliente e um setup válidos.");
                return;
            }

            try
            {
                Locacao novaLocacao = new Locacao(clienteSel, itemSel, dtpRetirada.Value, dtpDevolucao.Value);
                _locacaoService.Registrar(novaLocacao);

                AtualizarListagemLocacoes();
                MessageBox.Show($"Locação salva com sucesso!\nValor Total: R$ {novaLocacao.ValorTotal:N2}");
            }
            catch (AcessoNegadoException ex)
            {
                MessageBox.Show(ex.Message, "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar locação: " + ex.Message);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            Locacao locacaoSel = (Locacao)lstLocacoes.SelectedItem;
            if (locacaoSel == null)
            {
                MessageBox.Show("Selecione uma locação ativa na lista para realizar a devolução.");
                return;
            }

            try
            {
                _locacaoService.RegistrarDevolucao(locacaoSel.Id);
                AtualizarListagemLocacoes();
                MessageBox.Show("Devolução concluída! O equipamento retornou ao estoque.");
            }
            catch (AcessoNegadoException ex)
            {
                MessageBox.Show(ex.Message, "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar devolução: " + ex.Message);
            }
        }

        // LOCAÇÃO - Excluir (cancelar locação cadastrada por erro)
        private void btnExcluirLocacao_Click(object sender, EventArgs e)
        {
            Locacao locacaoSel = (Locacao)lstLocacoes.SelectedItem;
            if (locacaoSel == null)
            {
                MessageBox.Show("Selecione uma locação na lista para excluir.");
                return;
            }

            var confirmacao = MessageBox.Show(
                $"Tem certeza que deseja excluir esta locação?\n{locacaoSel}",
                "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao != DialogResult.Yes) return;

            try
            {
                _locacaoService.Excluir(locacaoSel.Id);
                AtualizarListagemLocacoes();
                MessageBox.Show("Locação excluída com sucesso!");
            }
            catch (AcessoNegadoException ex)
            {
                MessageBox.Show(ex.Message, "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir locação: " + ex.Message);
            }
        }

        private void AtualizarListagemLocacoes()
        {
            try
            {
                List<Locacao> ativas = _locacaoService.ObterAtivas();

                lstLocacoes.DataSource = null;
                lstLocacoes.DataSource = ativas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar locações do banco: " + ex.Message);
            }
        }

        // ===================== UPGRADE =====================
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

        private void btnAplicarUpgrade_Click_1(object sender, EventArgs e)
        {
            Item setupSel = (Item)cmbSetupsUpgrade.SelectedItem;
            if (setupSel == null)
            {
                MessageBox.Show("Selecione um setup para aplicar o upgrade.");
                return;
            }

            string pecaTexto = Microsoft.VisualBasic.Interaction.InputBox(
                "Digite o nome da nova peça para o Upgrade:", "Novo Componente", "");

            if (string.IsNullOrWhiteSpace(pecaTexto)) return;

            try
            {
                bool estaAlugado = _locacaoService.ItemEstaAlugado(setupSel.Id);
                if (estaAlugado)
                {
                    MessageBox.Show("❌ Bloqueado! Este computador está atualmente alugado por um cliente.", "Aviso");
                    return;
                }

                setupSel.Componentes.Add(pecaTexto.Trim());
                _itemService.AtualizarComponentes(setupSel);

                cmbSetupsUpgrade_SelectedIndexChanged(this, EventArgs.Empty);
                MessageBox.Show("⚡ Upgrade concluído com sucesso!");
            }
            catch (AcessoNegadoException ex)
            {
                MessageBox.Show(ex.Message, "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aplicar upgrade: " + ex.Message);
            }
        }

        // UPGRADE - Remover peça selecionada na lista lstPecasAtuais
        private void btnRemoverPeca_Click(object sender, EventArgs e)
        {
            Item setupSel = (Item)cmbSetupsUpgrade.SelectedItem;
            if (setupSel == null)
            {
                MessageBox.Show("Selecione um setup primeiro.");
                return;
            }

            if (lstPecasAtuais.SelectedItem == null)
            {
                MessageBox.Show("Selecione, na lista de componentes, a peça que deseja remover.");
                return;
            }

            string pecaSelecionada = lstPecasAtuais.SelectedItem.ToString();

            try
            {
                bool estaAlugado = _locacaoService.ItemEstaAlugado(setupSel.Id);
                if (estaAlugado)
                {
                    MessageBox.Show("❌ Bloqueado! Este computador está atualmente alugado por um cliente.", "Aviso");
                    return;
                }

                // Remove apenas a primeira ocorrência exata da peça selecionada
                setupSel.Componentes.Remove(pecaSelecionada);
                _itemService.AtualizarComponentes(setupSel);

                cmbSetupsUpgrade_SelectedIndexChanged(this, EventArgs.Empty);
                MessageBox.Show("Peça removida com sucesso!");
            }
            catch (AcessoNegadoException ex)
            {
                MessageBox.Show(ex.Message, "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover peça: " + ex.Message);
            }
        }

        // ===================== USUÁRIOS DO SISTEMA (só Admin) =====================
        private void CarregarPapeis()
        {
            try
            {
                var papeis = _usuarioService.ObterPapeis();
                cmbPapelUsuario.DataSource = papeis;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar papéis: " + ex.Message);
            }
        }

        private void AtualizarListaUsuarios()
        {
            try
            {
                if (!SessaoUsuario.EhAdmin) return; // só Admin pode ver a lista

                var usuarios = _usuarioService.ObterTodos();
                lstUsuarios.DataSource = null;
                lstUsuarios.DataSource = usuarios;
            }
            catch (AcessoNegadoException)
            {
                // Não-admin: simplesmente não popula a lista, sem mensagem de erro
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar usuários: " + ex.Message);
            }
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeDoUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtLoginUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtSenhaUsuario.Text))
            {
                MessageBox.Show("Preencha nome, login e senha.");
                return;
            }

            Papel papelSel = (Papel)cmbPapelUsuario.SelectedItem;
            if (papelSel == null)
            {
                MessageBox.Show("Selecione um papel para o novo usuário.");
                return;
            }

            try
            {
                var novoUsuario = new Usuario
                {
                    Nome = txtNomeDoUsuario.Text,
                    Login = txtLoginUsuario.Text,
                    PapelId = papelSel.Id
                };

                // A senha em texto puro só existe até esta linha — o Service/Repository
                // transforma em hash BCrypt antes de qualquer gravação no banco.
                _usuarioService.Salvar(novoUsuario, txtSenhaUsuario.Text);

                MessageBox.Show("Usuário cadastrado com sucesso!");

                txtNomeUsuario.Clear();
                txtLoginUsuario.Clear();
                txtSenhaUsuario.Clear();
                AtualizarListaUsuarios();
            }
            catch (AcessoNegadoException ex)
            {
                MessageBox.Show(ex.Message, "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
            }
        }

        private void lblNomeUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblLoginUsuario_Click(object sender, EventArgs e)
        {

        }

        private void tabUsuarios_Click(object sender, EventArgs e)
        {

        }
    }
}