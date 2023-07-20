using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

public partial class Tipado
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<PdfSeccion> PdfSeccions { get; set; } = new List<PdfSeccion>();

    public virtual ICollection<Pdf> Pdfs { get; set; } = new List<Pdf>();

    public virtual ICollection<ValorDefecto> ValorDefectos { get; set; } = new List<ValorDefecto>();
}
