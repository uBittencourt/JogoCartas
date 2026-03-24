using JogoCartas.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoCartas.Core.Models
{
    public class Partida<T> where T : Carta
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public StatusPartida Status { get; set; } = StatusPartida.NaoIniciada;
        public List<Jogador<T>> Jogadores { get; init; } = new();
        public Rodada<T>? RodadaAtual { get; set; }
    }
}
