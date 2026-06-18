using projeto.Models;

namespace projeto.Services
{
    // Guarda o usuário logado durante toda a execução do programa.
    // É uma classe "estática" porque só existe UM usuário logado por vez
    // (não temos múltiplas janelas/sessões simultâneas num WinForms comum).
    public static class SessaoUsuario
    {
        public static Usuario UsuarioLogado { get; private set; }

        public static void IniciarSessao(Usuario usuario)
        {
            UsuarioLogado = usuario;
        }

        public static void EncerrarSessao()
        {
            UsuarioLogado = null;
        }

        public static bool EstaLogado => UsuarioLogado != null;

        public static bool EhAdmin => UsuarioLogado?.NomePapel == "Admin";

        public static bool EhOperadorOuSuperior =>
            UsuarioLogado?.NomePapel == "Operador" || EhAdmin;

        // Visualizador só lê; qualquer outro papel pode escrever no domínio
        public static bool PodeEscreverNoDominio => EhOperadorOuSuperior;
    }
}