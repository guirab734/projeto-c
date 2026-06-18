using System.Collections.Generic;
using projeto.Models;
using projeto.Repositories;

namespace projeto.Services
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _repository = new UsuarioRepository();

        // Só Admin pode cadastrar novos usuários e definir seus papéis
        public void Salvar(Usuario usuario, string senhaTextoPuro)
        {
            if (!SessaoUsuario.EhAdmin)
                throw new AcessoNegadoException("Apenas o Admin pode cadastrar usuários.");

            _repository.Salvar(usuario, senhaTextoPuro);
        }

        public List<Usuario> ObterTodos()
        {
            if (!SessaoUsuario.EhAdmin)
                throw new AcessoNegadoException("Apenas o Admin pode visualizar a lista de usuários.");

            return _repository.ObterTodos();
        }

        // Usado SOMENTE na tela de login, antes de existir qualquer sessão.
        // Por isso não passa pela checagem de SessaoUsuario.
        public Usuario Autenticar(string login, string senha)
        {
            var usuario = _repository.BuscarPorLogin(login);
            if (usuario == null)
                return null; // login não encontrado

            bool senhaCorreta = _repository.ValidarSenha(senha, usuario.SenhaHash);
            return senhaCorreta ? usuario : null;
        }
    }
}