using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoCartas.Core.Records
{
    public readonly record struct JogadorHistorico(
        Guid Id,
        string Nome
    );
}
