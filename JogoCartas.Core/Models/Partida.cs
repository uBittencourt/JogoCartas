using JogoCartas.Core.Enums;
using JogoCartas.Core.Records;
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
        public List<Rodada<T>> Rodadas { get; init; } = new();

        public void IniciarRodada(Baralho<T> baralho)
        {
            RodadaAtual = new Rodada<T>(Jogadores, baralho);
        }
        public void FinalizarRodada()
        {
            RodadaAtual = null;
        }

        public PartidaHistorico GerarHistorico(DateTime inicio, DateTime? fim, List<Rodada<T>> rodadas)
        {
            return new PartidaHistorico(
                Id,
                Status,
                inicio,
                fim,
                Jogadores.Select(j => new JogadorHistorico(
                    j.Id,
                    j.Nome
                )).ToList(),
                rodadas.Select((r, index) => new RodadaHistorico(
                    r.Id,
                    index + 1
                )).ToList()
            );
        }
    }
}
