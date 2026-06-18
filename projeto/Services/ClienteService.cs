using System.Collections.Generic;
using projeto.Models;
using projeto.Repositories;

namespace projeto.Services
{
    public class ClienteService
    {
        private readonly ClienteRepository _repository = new ClienteRepository();

        public List<Cliente> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public void Salvar(Cliente cliente)
        {
            if (!SessaoUsuario.PodeEscreverNoDominio)
                throw new AcessoNegadoException("Seu papel não permite cadastrar clientes.");

            _repository.Salvar(cliente);
        }

        public void Atualizar(Cliente cliente)
        {
            if (!SessaoUsuario.PodeEscreverNoDominio)
                throw new AcessoNegadoException("Seu papel não permite editar clientes.");

            _repository.Atualizar(cliente);
        }

        public void Excluir(int clienteId)
        {
            if (!SessaoUsuario.PodeEscreverNoDominio)
                throw new AcessoNegadoException("Seu papel não permite excluir clientes.");

            // Mantemos o histórico de locações sempre — um cliente que já
            // alugou alguma vez (mesmo já devolvido) não pode ser excluído,
            // só editado. É a mesma regra que o banco já impõe via FOREIGN KEY,
            // mas aqui damos uma mensagem clara em vez do erro técnico do SQLite.
            if (_repository.TemHistoricoDeLocacoes(clienteId))
                throw new AcessoNegadoException(
                    "Este cliente possui histórico de locações e não pode ser excluído (apenas editado), para preservar o histórico do sistema.");

            _repository.Excluir(clienteId);
        }
    }
}