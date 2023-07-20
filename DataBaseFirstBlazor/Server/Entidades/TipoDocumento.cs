using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

public partial class TipoDocumento
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public string? Alias { get; set; }

    public virtual ICollection<Json> Jsons { get; set; } = new List<Json>();

    public virtual ICollection<ValorDefecto> ValorDefectos { get; set; } = new List<ValorDefecto>();
}
