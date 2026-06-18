using System;
using System.Windows.Forms;
using projeto.Services;

namespace projeto
{
    public partial class FormLogin : Form
    {
        private readonly UsuarioService _usuarioService = new UsuarioService();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string senha = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Informe login e senha.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuario = _usuarioService.Autenticar(login, senha);

            if (usuario == null)
            {
                MessageBox.Show("Login ou senha inválidos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Clear();
                txtSenha.Focus();
                return;
            }

            // Guarda o usuário logado para o resto do programa consultar o papel
            SessaoUsuario.IniciarSessao(usuario);

            // Abre o sistema principal e fecha a tela de login
            var formPrincipal = new Form1();
            this.Hide();
            formPrincipal.ShowDialog();
            this.Close();
        }
    }
}