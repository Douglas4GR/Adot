# Adot

Este projeto é uma aplicação web desenvolvida com ASP.NET Core e Blazor, focada na adoção de pets e interação através de chats. Ele combina funcionalidades de adoção de animais com recursos de comunicação em tempo real, permitindo que os usuários encontrem e adotem pets enquanto interagem através de salas de chat.

> ### Palavras-Chave:
> - C#
> - ASP.NET Core
> - Blazor
> - Entity Framework Core
> - SQL Server
> - .NET 8

## Swagger

![Operações](PetAdoptionAndChat/Imagens/metodos.png)

![Esquemas1](PetAdoptionAndChat/Imagens/orderSchema.png)

![Esquemas1](PetAdoptionAndChat/Imagens/productSchema.png)

### As operações atuais incluem:
- Inserir novo pet para adoção
- Listar pets disponíveis para adoção
- Iniciar processo de adoção de um pet específico

### E os esquemas:
- Pet
- AdoptionRequest
- ChatRoom
- Message

# Estrutura do Projeto
```plaintext
.
├── Adot
│   ├── Client
│   │   ├── Pages
│   │   │   ├── AdoptPets.razor
│   │   │   ├── Chat.razor
│   │   │   └── Index.razor
│   │   ├── wwwroot
│   │   ├── App.razor
│   │   ├── MainLayout.razor
│   │   └── Program.cs
│   ├── Server
│   │   ├── Controllers
│   │   │   ├── AdoptionController.cs
│   │   │   ├── ChatController.cs
│   │   │   └── WeatherForecastController.cs
│   │   ├── Data
│   │   │   └── PetAdoptionContext.cs
│   │   ├── Models
│   │   │   ├── Pet.cs
│   │   │   ├── AdoptionRequest.cs
│   │   │   ├── ChatRoom.cs
│   │   │   └── Message.cs
│   │   ├── obj
│   │   ├── PetAdoptionAndChat.csproj
│   │   ├── PetAdoptionAndChat.sln
│   │   ├── Program.cs
│   │   ├── Properties
│   │   │   └── launchSettings.json
│   │   ├── Startup.cs
│   │   └── WeatherForecast.cs
├── .gitattributes
├── .gitignore
├── LICENSE
├── PetAdoptionAndChat.sln
└── README.md
```

### Detalhes dos Arquivos e Pastas
- Adot: Diretório principal do projeto.
  - Client: Contém os arquivos relacionados ao lado cliente do projeto Blazor.
  - Pages: Páginas Blazor do cliente.
  - wwwroot: Conteúdo estático do lado cliente.
  - App.razor: Componente principal do aplicativo Blazor.
  - MainLayout.razor: Layout principal do aplicativo.
  - Program.cs: Ponto de entrada para o lado cliente do aplicativo Blazor.
  - Server: Contém os arquivos relacionados ao lado servidor do projeto ASP.NET Core.
  - Controllers: Controladores da API.
  - Data: Arquivos de contexto e configuração do banco de dados.
  - Models: Modelos de dados do projeto.
  - obj: Diretório de compilação temporária.
  - PetAdoptionAndChat.csproj: Arquivo de projeto do .NET.
  - PetAdoptionAndChat.sln: Solução do projeto.
  - Program.cs: Ponto de entrada para o lado servidor do aplicativo ASP.NET Core.
  - Properties: Configurações do projeto.
  - Startup.cs: Configuração inicial do aplicativo.
- Outros arquivos e pastas padrão como .gitattributes, .gitignore, LICENSE, PetAdoptionAndChat.sln, e README.md.

## Instalação
Clone o Repositório
bash
```
git clone https://github.com/seu-usuario/PetAdoptionAndChat.git
```
Navegue até o diretório do projeto:
bash
```
cd PetAdoptionAndChat
```
Restaure as dependências do projeto:
```
dotnet restore
```
Atualize o banco de dados para a última versão de migração:
sql
```
dotnet ef database update
```
## Uso
Para iniciar a aplicação, use o comando:

arduino
```
dotnet run
```
## Contribuição
Faça um fork do projeto.
Crie uma nova branch:

```css
git checkout -b minha-nova-feature
```

Faça suas alterações e commit:
sql
```
git commit -m 'Adiciona nova feature'
```

Envie para a branch original:
```perl
git push origin minha-nova-feature
```

Crie um pull request.
Tecnologias utilizadas
ASP.NET Core 8.0
Blazor
Entity Framework Core (SQL Server)
.NET 8
## Licença
Este projeto está licenciado sob a Licença MIT - veja o arquivo LICENSE para mais detalhes.
