using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

public partial class ValorDefecto
{
    public int Id { get; set; }

    public string Columna { get; set; } = null!;

    public int? IdTipoDocumento { get; set; }

    public bool Cabecera { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Valor { get; set; } = null!;

    public int IdTipado { get; set; }

    public virtual Tipado IdTipadoNavigation { get; set; } = null!;

    public virtual TipoDocumento? IdTipoDocumentoNavigation { get; set; }
}
