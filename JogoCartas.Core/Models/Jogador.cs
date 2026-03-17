using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoCartas.Core.Models
{
    public class Jogador(string nome)
    {
        public string Nome { get; set; } = nome;
        public int Pontos { get; private set; } = 0;
        public List<Carta> Mao { get; private set; } = new List<Carta>();
        public void ReceberCarta(Carta carta)
        {
            Mao.Add(carta);
        }
    }
}
