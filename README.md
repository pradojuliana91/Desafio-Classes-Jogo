# Projeto de Herói de Aventura em C#

Este projeto em C# permite que o usuário crie um herói de uma aventura e o faça realizar ataques específicos com base em seu tipo (guerreiro, mago, monge ou ninja). O programa faz perguntas ao usuário para coletar informações sobre o herói e exibe uma mensagem com o tipo de ataque correspondente ao herói criado.

## Funcionalidades

- O programa faz perguntas ao usuário para determinar:
  - **Nome do herói**
  - **Idade do herói**
  - **Tipo do herói**: as opções são guerreiro, mago, monge ou ninja.
- O herói executa um ataque com base no seu tipo:
  - **Guerreiro**: usa espada.
  - **Mago**: usa magia.
  - **Monge**: usa artes marciais.
  - **Ninja**: usa shuriken.
- Exibe uma mensagem formatada com o nome do tipo de herói e o tipo de ataque.

## Estrutura do Código

- **Heroi<T>**: Classe genérica que representa o herói.
  - Propriedades: `Nome`, `Idade`, `Tipo`.
  - Métodos:
    - `Atacar()`: Determina o ataque do herói com base no tipo.
    - `DeterminarAtaque()`: Retorna o tipo de ataque específico do herói (magia, espada, artes marciais, shuriken).
- **Program**: A classe principal que interage com o usuário, faz as perguntas e exibe o resultado.

## Tecnologias Utilizadas

- Linguagem de Programação: **C#**
- Plataforma: **.NET Core**