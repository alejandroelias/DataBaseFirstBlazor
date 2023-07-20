using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

public partial class PdfSeccion
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int IdTipado { get; set; }

    public int IdJson { get; set; }

    public int? IdPdfVinculacion { get; set; }

    public bool EliminarVacios { get; set; }

    public virtual Json IdJsonNavigation { get; set; } = null!;

    public virtual PdfVinculacion? IdPdfVinculacionNavigation { get; set; }

    public virtual Tipado IdTipadoNavigation { get; set; } = null!;

    public virtual ICollection<Pdf> Pdfs { get; set; } = new List<Pdf>();
}
