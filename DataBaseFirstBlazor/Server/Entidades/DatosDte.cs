using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

public partial class DatosDte
{
    public string? Idcontrol { get; set; }

    public string TipoDoc { get; set; } = null!;

    public string Bd { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string? Log { get; set; }

    public string? Error { get; set; }
}
