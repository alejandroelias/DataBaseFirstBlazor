using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

public partial class Color
{
    public int Id { get; set; }

    public bool Blanco { get; set; }

    public string Valor { get; set; } = null!;

    public virtual ICollection<Estado> Estados { get; set; } = new List<Estado>();

    public virtual ICollection<Registro> Registros { get; set; } = new List<Registro>();
}
