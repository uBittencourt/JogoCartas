using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoCartas.Core.Models
{
    public enum Naipe { Ouros, Espadas, Copas, Paus }
    public enum Valor { As, Dois, Tres, Quatro, Cinco, Seis, Sete, Oito, Nove, Dez, Valete, Dama, Rei }
    
    public abstract class Carta
    {
        public Naipe Naipe { get; private set; }
        public Valor Valor { get; private set; }

        public Carta(Naipe naipe, Valor valor)
        {
            Naipe = naipe;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"{Valor} de {Naipe}";
        }
        //public string Naipe { get; set; }
        //public string Valor { get; set; }
    }
}
