using System.Collections.Generic;
using projeto.Models;
using projeto.Repositories;

namespace projeto.Services
{
    public class ItemService
    {
        private readonly ItemRepository _repository = new ItemRepository();
        private readonly LocacaoRepository _locacaoRepository = new LocacaoRepository();

        public List<Item> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public void Salvar(Item item)
        {
            if (!SessaoUsuario.PodeEscreverNoDominio)
                throw new AcessoNegadoException("Seu papel não permite cadastrar setups.");

            _repository.Salvar(item);
        }

        public void Atualizar(Item item)
        {
            if (!SessaoUsuario.PodeEscreverNoDominio)
                throw new AcessoNegadoException("Seu papel não permite editar setups.");

            _repository.Atualizar(item);
        }

        public void Excluir(int itemId)
        {
            if (!SessaoUsuario.PodeEscreverNoDominio)
                throw new AcessoNegadoException("Seu papel não permite excluir setups.");

            // Mesma regra do Cliente: preservar histórico de locações sempre
            if (_repository.TemHistoricoDeLocacoes(itemId))
                throw new AcessoNegadoException(
                    "Este setup possui histórico de locações e não pode ser excluído (apenas editado), para preservar o histórico do sistema.");

            _repository.Excluir(itemId);
        }

        public void AtualizarComponentes(Item item)
        {
            if (!SessaoUsuario.PodeEscreverNoDominio)
                throw new AcessoNegadoException("Seu papel não permite alterar componentes de setups.");

            _repository.AtualizarComponentes(item);
        }
    }
}