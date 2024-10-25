## Este repositório contém um projeto de Web API desenvolvido em C# utilizando ASP.NET Core, conforme solicitado pela empresa PlayMove. O projeto implementa operações básicas de CRUD para a entidade **Fornecedor** e foi projetado para seguir boas práticas de desenvolvimento.

## Tarefas Implementadas

### 1. Configuração Inicial

- Criado um projeto de Web API utilizando **ASP.NET Core**.
- Configurada a conexão com um banco de dados SQL Server.
- Implementadas operações básicas de CRUD para a entidade **Fornecedor**.

### 2. Endpoints da API

A API expõe os seguintes endpoints para gerenciamento de fornecedores:

- **GET** `/api/fornecedores`  
  Retorna todos os fornecedores.

- **GET** `/api/fornecedores/{id}`  
  Retorna um fornecedor específico pelo ID.

- **POST** `/api/fornecedores`  
  Adiciona um novo fornecedor.

- **PUT** `/api/fornecedores/{id}`  
  Atualiza um fornecedor existente pelo ID.

- **DELETE** `/api/fornecedores/{id}`  
  Remove um fornecedor pelo ID.

### 3. Modelagem de Dados

A entidade **Fornecedor** foi modelada com os seguintes atributos:

- **Id** (int): Identificador único do fornecedor.
- **Nome** (string): Nome do fornecedor.
- **Email** (string): Endereço de e-mail do fornecedor.
- **Telefone** (string): Número de telefone do fornecedor.
- **Descrição** (string, opcional): Descrição adicional do fornecedor.


### 4. Documentação

A documentação da API foi gerada utilizando **Swagger**. Para visualizar a documentação:

1. Execute o projeto.
2. Acesse `http://localhost:{port}/swagger` em seu navegador.
