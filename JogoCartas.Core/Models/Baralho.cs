using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoCartas.Core.Models
{
    public class Baralho<T> where T : Carta
    {
        private List<T> _cartas = new List<T>();

        public void Adicionar(T carta) => _cartas.Add(carta);

        public void Embaralhar()
        {
            var _random = new Random();
            _cartas = _cartas.OrderBy(a => _random.Next()).ToList();
        }

        public T PegarCarta() 
        {
            if (_cartas.Count == 0)
                throw new InvalidOperationException("O baralho está vazio.");
            T carta = _cartas[0];
            _cartas.RemoveAt(0);
            return carta;
        }
    }
}
