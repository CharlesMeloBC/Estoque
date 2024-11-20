# Estoque

Este projeto é responsável por transpor um banco de dados de arquivos XML para um formato mais eficiente. Ele inclui funcionalidades como:
- Registro de logs.
- Sistema de autenticação.
- CRUD.
- (Opcional) Mensageria para envio e recebimento de notificações.

---

## Requisitos

- **.NET SDK** 7.0 ou superior.
- Banco de dados (SQLite, MySQL ou outro).
- Bibliotecas adicionais:
  - Serilog (para logs).
  - Biblioteca de autenticação (ex.: IdentityServer ou JWT).
  - (Opcional) Biblioteca de mensageria (ex.: RabbitMQ, Azure Service Bus).

---

## Configuração

1. Clone o repositório:
   ```bash
   git clone https://github.com/CharlesMeloBC/Estoque/


---

#### 4. **Funcionalidades**
Explique cada funcionalidade implementada.

```markdown
## Funcionalidades

### 1. Transposição de Banco de Dados
- Transforma dados de arquivos XML em um banco de dados relacional.
- Suporta validação e logs durante o processo.

### 2. Logs
- Utiliza [Serilog](https://serilog.net/) para registrar eventos.
- Logs de:
  - Transposição de dados.
  - Erros de autenticação.
  - Mensageria (se habilitada).

### 3. Autenticação
- Implementada usando JWT.
- Rotas protegidas com perfis de usuário:
  - **Admin:** Acesso total.
  - **Usuário comum:** Acesso a funcionalidades específicas.

### 4. Mensageria (Opcional)
- Envio e recebimento de mensagens através do RabbitMQ.
- Notificações em tempo real para transações críticas.
```

## Instale as dependências do projeto

```
dotnet restore
```

## Configure o banco de dados:
- Edite o arquivo appsettings.json para adicionar a string de conexão.
- Exemplo:
```
"ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=minha_aplicacao;User Id=seu_usuario;Password=sua_senha;"
}
```
