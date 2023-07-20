using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

/// <summary>
/// descrpicion de tipo de accion
/// </summary>
public partial class Accion
{
    public int Id { get; set; }

    /// <summary>
    /// se representara como el titulo del correo
    /// </summary>
    public string Nombre { get; set; } = null!;

    public virtual ICollection<Cabecera> Cabeceras { get; set; } = new List<Cabecera>();

    public virtual ICollection<CorreoXAccion> CorreoXAccions { get; set; } = new List<CorreoXAccion>();
}
