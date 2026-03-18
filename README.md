# Task Manager API 🚀

Uma API robusta para o gerenciamento de tarefas, desenvolvida em **.NET 8** seguindo os princípios da **Clean Architecture**. O projeto permite o registo, visualização, edição e exclusão de tarefas, facilitando o controlo de produtividade.

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C#
- **Framework:** .NET 8.0
- **Arquitetura:** Clean Architecture (API, Application, Communication)
- **Documentação:** Swagger (OpenAPI) para exploração de endpoints.

## 📁 Estrutura do Projeto

O repositório está organizado da seguinte forma:

- **TaskManager.API:** Ponto de entrada da aplicação, contendo os Controllers e a configuração da porta de entrada.
- **TaskManager.Application:** Camada de lógica de negócio e os Casos de Uso (Use Cases).
- **TaskManager.Communication:** Contratos de entrada e saída (Requests/Responses) e Enums como o `StatusEnum`.

## 🚀 Como Executar o Projeto

### Pré-requisitos

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) instalado.
- IDE de sua preferência (Visual Studio 2022 ou VS Code).

### Passo a Passo

1. **Clonar o repositório:**
   ```bash
   git clone [https://github.com/LukeUp2/TaskManager.git](https://github.com/LukeUp2/TaskManager.git)
   cd TaskManager
   ```
