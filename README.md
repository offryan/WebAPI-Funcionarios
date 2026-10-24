# 🧩 WebAPI Funcionários

API REST para gestão de funcionários de uma empresa, com CRUD completo, inativação de funcionários e documentação no Swagger.

## 🛠️ Tecnologias

- **C#** e **.NET 6** (ASP.NET Core Web API)
- **Entity Framework Core 7** com migrations
- **SQL Server**
- **Swagger** (Swashbuckle)
- Camada de serviço com injeção de dependência e respostas padronizadas (`ServiceResponse<T>`)

## 📌 Endpoints

| Método | Rota | Descrição |
|---|---|---|
| `GET` | `/api/Funcionario` | Lista todos os funcionários |
| `GET` | `/api/Funcionario/{id}` | Busca um funcionário pelo id |
| `POST` | `/api/Funcionario` | Cadastra um funcionário |
| `PUT` | `/api/Funcionario` | Edita um funcionário |
| `PUT` | `/api/Funcionario/InativaFuncionarios?id={id}` | Inativa um funcionário |
| `DELETE` | `/api/Funcionario?id={id}` | Exclui um funcionário |

**Funcionário:** `Nome`, `Sobrenome`, `Departamento` (RH, Financeiro, Compras, Atendimento, Zeladoria), `Turno` (Manhã, Tarde, Noite), status ativo e datas de criação e alteração.

## Abaixo segue um demonstrativo de como funciona a API, com imagens e vídeos!

### Página incial ' Swagger UI '
![Api_homepage](https://github.com/offryan/WebAPI-Funcionarios/assets/85769101/01b4bd34-f74a-4ded-9ce5-4f74e0bda114)

### Esquemas ' Swagger UI '
![esquemaSwagger](https://github.com/offryan/WebAPI-Funcionarios/assets/85769101/c6b0f605-6fe2-4a27-905c-5a0e9b53eef1)

### Retorno de dados ' MSSQL Server '
![SqlServerPrint](https://github.com/offryan/WebAPI-Funcionarios/assets/85769101/227b6209-8090-4435-b96d-cdfa24516f2e)

## ▶️ Rodando localmente

Pré-requisitos: .NET 6 SDK e SQL Server.

```bash
git clone https://github.com/offryan/WebAPI-Funcionarios.git
cd WebAPI-Funcionarios
```

1. Ajuste a `DefaultConnection` em `appsettings.json` para o seu SQL Server.
2. Crie o banco com as migrations:
   ```bash
   dotnet tool install --global dotnet-ef
   dotnet ef database update
   ```
3. Rode a API e abra o Swagger no endereço exibido no terminal (`/swagger`):
   ```bash
   dotnet run
   ```
