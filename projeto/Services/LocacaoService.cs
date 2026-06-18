using System.Collections.Generic;
using projeto.Models;
using projeto.Repositories;

namespace projeto.Services
{
    public class LocacaoService
    {
        private readonly LocacaoRepository _repository = new LocacaoRepository();

        public List<Locacao> ObterAtivas()
        {
            return _repository.ObterAtivas();
        }

        public List<Locacao> ObterTodas()
        {
            return _repository.ObterTodas();
        }

        public void Registrar(Locacao locacao)
        {
            if (!SessaoUsuario.PodeEscreverNoDominio)
                throw new AcessoNegadoException("Seu papel não permite registrar locações.");

            _repository.Salvar(locacao);
        }

        public void RegistrarDevolucao(int locacaoId)
        {
            if (!SessaoUsuario.PodeEscreverNoDominio)
                throw new AcessoNegadoException("Seu papel não permite registrar devoluções.");

            _repository.RegistrarDevolucao(locacaoId);
        }

        public void Excluir(int locacaoId)
        {
            if (!SessaoUsuario.PodeEscreverNoDominio)
                throw new AcessoNegadoException("Seu papel não permite excluir locações.");

            _repository.Excluir(locacaoId);
        }

        public bool ItemEstaAlugado(int itemId)
        {
            return _repository.ItemEstaAlugado(itemId);
        }
    }
}