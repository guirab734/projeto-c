using System;

namespace projeto.Services
{
    // Exception específica para quando o papel do usuário não permite a ação.
    // Lançar uma exception própria (em vez de uma genérica) deixa claro,
    // em qualquer lugar do código, que o motivo foi falta de permissão.
    public class AcessoNegadoException : Exception
    {
        public AcessoNegadoException(string mensagem) : base(mensagem)
        {
        }
    }
}