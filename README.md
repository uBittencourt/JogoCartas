# 🃏 CP1 - HandsOn 04

Neste quarto HandsOn, foi preciso evoluir o projeto class library para um jogo de cartas genérico, utilizando novas estruturas aprendidas para criar um histórico dos dados dos jogos de forma mais otimizada que o convencional

---

# 🛠️ Classes e Estruturas Criadas

## 1. Carta
A base genérica do projeto, onde existe atributos que contém em qualquer tipo de jogo, que é uma categoria/tipo e um valor/peso.

## 2. Jogador
É o participante do jogo, que tem uma mão com suas cartas, definidas de forma genérica, de forma que o jogador possa receber cartas de qualquer tipo.

## 3. Baralho
Cria a lógica de qualquer jogo de baralho, embaralhando, adicionando e removendo cartas.

## 4. Partida e Rodada
Definem a lógica dos jogos, a rodada recebendo os jogadores, o baralho e a implementando a distribuição de cartas, e a partida administrando o histórico e o real vencedor.

## 5. StatusPartida
Estrutura criada para padronizar o estado atual da partida.

## 6. Records de Histórico

Como solicitado, records foram criados para armazenar o histórico dos jogos, garantindo a otimização do uso da memória
- **Readonly Record Struct**: usado para armazenar o histórico da rodada e jogador, dados leves e imutáveis.
- **Record**: usado para armazenar o histórico da partida, já que contém dados mais complexos, mas também imutáveis.

## 7. Identificação de Vencedores
Funcionalidade adicionada para identificar o vencedor das rodadas e partidas, utilizando `Guid` para garantir jogadores únicos e facilitar o registro do histórico.

---

# 🧑‍🎓 Integrantes - 3ESPG

| Nome | RM |
| :--- | :--- |
| Vinicius Fernandes Tavares Bittencourt | RM558909 |

---
