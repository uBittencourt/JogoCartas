using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoCartas.Core.Models
{
    public class Rodada<T>(List<Jogador<T>> jogadores, Baralho<T> baralho) where T : Carta
    {
        private List<Jogador<T>> _jogadores = jogadores;
        private Baralho<T> _baralho = baralho;

        public void DistribuirCartas(int quantidadePorJogador = 3)
        {
            foreach (var jogador in _jogadores)
            {
                jogador.Mao.Clear();

                for (int i = 0; i < quantidadePorJogador; i++)
                {
                    T cartaSorteada = _baralho.PegarCarta();
                    jogador.ReceberCarta(cartaSorteada);
                }
            }
        }
    }
}
