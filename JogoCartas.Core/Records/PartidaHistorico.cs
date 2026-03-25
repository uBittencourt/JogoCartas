using JogoCartas.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoCartas.Core.Records
{
    public record PartidaHistorico(
        Guid Id,
        StatusPartida Status,
        DateTime Inicio,
        DateTime? Fim,
        Guid? VencedorPartidaId,
        IReadOnlyList<JogadorHistorico> Jogadores,
        IReadOnlyList<RodadaHistorico> Rodadas
    );
}
