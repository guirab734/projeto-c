# 🎮 GGAMES - Sistema de Gestão de Locação de Setups

Bem-vindo ao repositório do **GGAMES**, um sistema Desktop em C# construído para gerenciar o aluguel de setups de alta performance, locações, devoluções e upgrades de hardware.

## 🚀 Sobre o Projeto
Este software é a evolução de um CRUD na memória para um produto real, integrando persistência de dados e níveis de segurança. O sistema gerencia toda a logística da GGAMES, desde o cadastro do cliente até a inclusão de novas peças (DDR5, RTX 50 Series) nos PCs.

## 🛠️ Tecnologias Utilizadas
* **Linguagem:** C# (.NET 10.0)
* **Interface:** Windows Forms + MaterialSkin (Tema Dark/Gamer)
* **Banco de Dados:** SQLite (local)
* **Segurança:** Autenticação e Hashing de senhas via **BCrypt**

## 🔐 Controle de Acesso (RBAC)
O sistema possui 3 papéis fixos:
1. **Visualizador:** Apenas leitura de dados e acesso ao Dashboard de Métricas.
2. **Operador:** Acesso a leitura e escrita no domínio (Locações, Clientes, Upgrades), sem acesso a gestão de usuários.
3. **Admin:** Controle total do sistema.

## ⚙️ Como Executar o Projeto
1. Clone este repositório.
2. Abra a solução (`projeto.slnx`) no Visual Studio.
3. Restaure os pacotes NuGet (SQLite, BCrypt, MaterialSkin).
4. Rode a aplicação. O banco `locacao.db` será criado automaticamente na primeira execução.
* **Usuário padrão para primeiro acesso:** `admin` | **Senha:** `admin123`

## 📦 Instalador
O projeto conta com um instalador final `.exe` gerado via **Inno Setup**, garantindo que o software rode em qualquer máquina limpa.