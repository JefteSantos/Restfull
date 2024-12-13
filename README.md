# Documentação da API Restfull

## Introdução
Restfull é uma API projetada para fins acadêmicos e de aprendizado. Ela permite que os usuários gerenciem categorias e produtos.

## Primeiros Passos
### Pré-requisitos
- .NET 8.0 SDK
- Visual Studio ou qualquer outro IDE

### Instalação
1. Clone o repositório:
   ```sh
   git clone https://github.com/JefteSantos/Restfull.git

2. Navegue até o diretório do projeto:
   cd restfull

3. Restaure as dependências:
   dotnet restore

4. Execute a aplicação:
   dotnet run

## Endpoints
### Obter Todas as Categorias
- URL: /categorias
- Método: GET
- Resposta:
  ```json
  [
    {
      "Id": 1,
      "Nome": "Categoria 1",
      "ImagemUrl": "Categoria1.jpg"
    },
    ...
  ]
  ```

### Criar uma Nova Categoria
- URL: /categorias
- Método: POST
- Corpo da Requisição:
  ```json
  {
    "Nome": "Categoria 7",
    "ImagemUrl": "categoria7.jpg"
  }
  ```
- Resposta:
  ```json
  {
    "Id": 7,
    "Nome": "Categoria 7",
    "ImagemUrl": "categoria7.jpg"
  }
  ```

## Tratamento de Erros
Os erros são retornados com códigos de status HTTP apropriados e um corpo JSON contendo a mensagem de erro.

## Autenticação
Atualmente, a API não requer autenticação.

## Limitação de Taxa
No momento, não há limites de taxa aplicados.

## Changelog
v1.0.0: Lançamento inicial com endpoints de gerenciamento de categorias.