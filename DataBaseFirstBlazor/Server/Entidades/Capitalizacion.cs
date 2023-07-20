using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

public partial class Capitalizacion
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Ejemplo { get; set; } = null!;

    public virtual ICollection<Pdf> Pdfs { get; set; } = new List<Pdf>();
}
