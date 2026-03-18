using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoCartas.Core.Models
{
    public class Jogador<T>(string nome) where T : Carta
    {
        public string Nome { get; set; } = nome;
        public int Pontos { get; private set; } = 0;
        public List<T> Mao { get; private set; } = new List<T>();
        public void ReceberCarta(T carta) => Mao.Add(carta);
    }
}
