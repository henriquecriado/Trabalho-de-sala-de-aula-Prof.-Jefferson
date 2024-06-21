# Gerenciamento de Estados de Tarefas em C#

Este projeto em C# foi desenvolvido para demonstrar um sistema simples de gerenciamento de estados de tarefas. Ele permite que você altere as tarefas, entre: Criado, em progresso, Concluido e Cancelado, utilizando conceitos de programação orientada a objetos e estruturas de dados simples. O projeto é desenvolvido em inglês, o que torna o projeto mais acessível e uniformizado para desenvolvedores de diferentes regiões. O uso do padrão state é fundamental para modelar comportamentos condicionais complexos de forma estruturada e eficiente em projetos de desenvolvimento de software. Ele promove a flexibilidade, a separação de responsabilidades e o controle preciso do fluxo de operações dentro do sistema.


## Modelagem do Sistema

### Estrutura do Projeto 
O projeto está estruturado da seguinte forma:
````
Task.cs: Classe que representa uma tarefa, contendo propriedades como título, descrição, estado e métodos para atualização.

TaskModel.cs: Classe responsável pelo gerenciamento das tarefas, incluindo métodos para adicionar: id, nome e descrição.

Program.cs: Arquivo principal onde a aplicação é iniciada. Contém um loop básico de interação com o usuário para demonstrar as funcionalidades.
````
### Padrão State

Esse padrão foi usado para criar os estados das tarefas.

Estado criado, em progresso, completo e cancelado.

A classe Task é composta por ID, Nome e Descritivo.

## Persistência de Dados 

Foi desenvolvido o Entity Framework.

## Como Executar

### Para executar o projeto:

1-Clone o repositório para sua máquina local.

2-Abra o projeto em um ambiente de desenvolvimento compatível com C#.

3-Compile e execute o projeto a partir do arquivo Program.cs

## Requisitos 

### Baixar ou ter o Visual Studio com versão 7.0 do .NET.

Baixar as ferramentas do Pacote Nuget: Microsoft.AspNetCore.OpenApi Versão 7.0. Microsoft.EntityFrameworkCore Versão 7.0. Microsoft.EntityFrameworkCore.Tools Versão 7.0. Npgsql Versão 7.0. Npgsql.EntityFrameworkCore.PostgreSQL Versão 7.0. Swashbuckle.AspNetCore Versão mais atual.
