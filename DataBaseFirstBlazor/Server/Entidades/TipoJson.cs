using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

/// <summary>
/// parseo, tipos de datos que se pueden configurar en el detalle del json
/// </summary>
public partial class TipoJson
{
    /// <summary>
    /// identity
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// nombre del tipo de dato
    /// </summary>
    public string Alias { get; set; } = null!;

    public string? Nombre { get; set; }
}
