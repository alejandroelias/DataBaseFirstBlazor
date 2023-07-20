using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

/// <summary>
/// correos a los que se les enviara distintas acciones al momento de realizar alguna tarea en los aplicativos
/// </summary>
public partial class Correo
{
    public int Id { get; set; }

    public string Valor { get; set; } = null!;

    public string? Nombre { get; set; }

    public virtual ICollection<CorreoXAccion> CorreoXAccions { get; set; } = new List<CorreoXAccion>();
}
