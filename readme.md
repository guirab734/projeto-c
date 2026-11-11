# GGAMES

Sistema desktop de locação de setups gamer em C# e Windows Forms. Reúne cadastro
de clientes e equipamentos, locações, devoluções e controle de acesso por perfil.
Os dados ficam em um arquivo SQLite local.

## Executar

Abra `projeto.slnx` no Visual Studio com o workload de desenvolvimento desktop
.NET instalado. Restaure os pacotes e execute o projeto Windows Forms.

O banco `locacao.db` é criado na primeira execução e não faz parte do repositório.
O cadastro inicial de desenvolvimento é criado em `DatabaseConnection.cs`.
Revise essa configuração antes de usar a aplicação fora de um ambiente de teste.

## Organização

- `Models`: entidades de cliente, item, locação e usuário.
- `Repositories`: leitura e escrita no SQLite.
- `Services`: regras de negócio e verificação de acesso.
- Formulários: interface e ações de cada tela.
