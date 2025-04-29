
# BattleGame

# 🕹️ Turn-Based Battle Game (C#)

Um jogo simples de batalha por turnos feito com C#, utilizando a estrutura do .NET, com foco em **boas práticas de programação**, **organização de código**, e **suporte multilíngue** para **português**, **inglês** e **turco**. Ideal para estudos, testes de lógica e construção de projetos didáticos.

---

## 📌 Descrição

Este projeto é um exemplo funcional de um sistema de combate baseado em turnos, onde jogadores e inimigos se alternam em ataques. O código é organizado com clareza e separado em camadas lógicas, facilitando o aprendizado de:

- Lógica de combate por turno
- Programação orientada a objetos (POO)
- Internacionalização (i18n) com suporte a 3 idiomas
- Probabilidades em ações de combate
- Tomada de decisão adaptativa da inteligência artificial

---

## 🧠 Inteligência do Inimigo

O inimigo no jogo possui um **comportamento adaptativo**, ou seja, ele ajusta suas ações com base no **nível de vida atual do jogador e dele mesmo**. Algumas estratégias incluem:

- Utilizar ataques mais fortes quando o jogador está vulnerável.
- Jogar de forma defensiva ou cautelosa quando estiver com pouca vida.
- Tomar decisões baseadas em **probabilidade de sucesso**, simulando uma IA simples.

Essa lógica é implementada de forma modular para fácil extensão e testes.

---

## 🎯 Sistema de Combate por Probabilidades

O sistema de combate é baseado em **probabilidades de acerto e dano**. Cada tipo de ataque possui:

- **Chance de acerto** (ex: 90% para ataque leve, 60% para ataque pesado)
- **Variação de dano** baseada em faixa aleatória
- Possibilidade de **crítico ou falha** em determinadas condições

Esse sistema introduz elementos de estratégia e imprevisibilidade ao jogo.

---

## 🌍 Idiomas Suportados

- 🇧🇷 Português
- 🇬🇧 English
- 🇹🇷 Türkçe

---

