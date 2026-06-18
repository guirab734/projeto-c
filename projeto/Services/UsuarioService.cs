using System.Collections.Generic;
using projeto.Models;
using projeto.Repositories;

namespace projeto.Services
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _repository = new UsuarioRepository();

        public void Salvar(Usuario usuario, string senhaTextoPuro)
        {
            if (!SessaoUsuario.EhAdmin)
                throw new AcessoNegadoException("Apenas o Admin pode cadastrar usuários.");

            if (_repository.LoginJaExiste(usuario.Login))
                throw new AcessoNegadoException($"Já existe um usuário com o login '{usuario.Login}'.");

            _repository.Salvar(usuario, senhaTextoPuro);
        }

        public List<Usuario> ObterTodos()
        {
            if (!SessaoUsuario.EhAdmin)
                throw new AcessoNegadoException("Apenas o Admin pode visualizar a lista de usuários.");

            return _repository.ObterTodos();
        }

        public List<Papel> ObterPapeis()
        {
            return _repository.ObterPapeis();
        }

        public Usuario Autenticar(string login, string senha)
        {
            var usuario = _repository.BuscarPorLogin(login);
            if (usuario == null)
                return null;

            bool senhaCorreta = _repository.ValidarSenha(senha, usuario.SenhaHash);
            return senhaCorreta ? usuario : null;
        }
    }
}