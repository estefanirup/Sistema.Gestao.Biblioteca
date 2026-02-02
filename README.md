# 📚 Sistema de Gestão de Biblioteca

Sistema completo para gerenciamento de biblioteca desenvolvido em **C#** com **Entity Framework Core**, aplicando conceitos de Programação Orientada a Objetos.

![C#](https://img.shields.io/badge/C%23-.NET-purple)
![EF Core](https://img.shields.io/badge/EF%20Core-ORM-blue)
![SQL Server](https://img.shields.io/badge/SQL%20Server-Database-red)

## ✨ Funcionalidades

- 📖 **Gerenciamento de Livros**
  - Cadastro com título, autor, gênero e disponibilidade
  - Suporte a diferentes tipos de mídia (Livro físico, E-book, Audiobook)

- 👥 **Gerenciamento de Membros**
  - Registro de usuários da biblioteca
  - Histórico individual de empréstimos

- 🔄 **Sistema de Empréstimos**
  - Controle de empréstimo e devolução
  - Cálculo automático de penalidades por atraso
  - Histórico completo de movimentações

## 🏗️ Arquitetura

O projeto aplica conceitos de **POO** e **Clean Architecture**:

```
┌─────────────────────────────────────────┐
│            Presentation Layer           │
│         (Console / MAUI - futuro)       │
└─────────────────────┬───────────────────┘
                      │
┌─────────────────────▼───────────────────┐
│            Application Layer            │
│              (Services)                 │
└─────────────────────┬───────────────────┘
                      │
┌─────────────────────▼───────────────────┐
│              Domain Layer               │
│         (Entities, Interfaces)          │
└─────────────────────┬───────────────────┘
                      │
┌─────────────────────▼───────────────────┐
│          Infrastructure Layer           │
│        (EF Core, Repositories)          │
└─────────────────────────────────────────┘
```

## 💡 Conceitos Aplicados

| Conceito | Aplicação no Projeto |
|----------|---------------------|
| **Abstração** | Classe base `Midia` define comportamento comum |
| **Encapsulamento** | Propriedades privadas com getters/setters |
| **Herança** | `Livro`, `Ebook`, `Audiobook` herdam de `Midia` |
| **Polimorfismo** | Tratamento uniforme de diferentes tipos de mídia |
| **Interfaces** | `IRepository<T>` para acesso a dados |
| **Exceções** | Tratamento de erros customizado |

## 🛠️ Tecnologias

| Tecnologia | Uso |
|------------|-----|
| **C# / .NET** | Linguagem e framework |
| **Entity Framework Core** | ORM para acesso a dados |
| **ADO.NET** | Persistência alternativa |
| **SQL Server** | Banco de dados |
| **MAUI** | Interface gráfica (em desenvolvimento) |


*Projeto desenvolvido para a disciplina de Programação Orientada a Objetos*
