using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoCartas.Core.Records
{
    public readonly record struct RodadaHistorico(
        Guid Id,
        int Numero,
        Guid? VencedorId
    );
}
